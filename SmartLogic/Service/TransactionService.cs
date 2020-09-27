using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartDataAccess;
using SmartHelper;
using SmartDomain;
using System.Globalization;

namespace SmartLogic
{

    public class TransactionService : ITransactionService
    {
        private readonly DatabaseContext _context;

        public TransactionService(DatabaseContext context) => _context = context;

        TransactionState GetTransactionState(int TransactionTypeID)
        {
            var transactionType = _context.TransactionType.Find(TransactionTypeID);
            TransactionState transactionState = (TransactionState)transactionType.TransactionStatusID;
            return transactionState;
        }
        public async Task<int> CreatePayment(Transaction PaymentsFile, TransactionTypeList transaction)
        {
            TransactionState transactionState = GetTransactionState(PaymentsFile.TransactionTypeID);
            decimal VATAmount = 0m;
            decimal AmountExclVat = 0m;
            decimal AmountInclVat = 0m;
            PaymentsFile.Year = DateTime.Now.Year;
            PaymentsFile.Month = DateTime.Now.Month;
            PaymentsFile.TransactionDate = DateTime.Now;
         
                    string _percentage = GetData.GetSettingValue((int)AppSetting.VAT_Percentage).Value;
                    decimal _vatPercentage = 0;
                    try
                    {
                        _vatPercentage = decimal.Parse(_percentage, CultureInfo.InvariantCulture); ;
                    }
                    catch (Exception)
                    {

                        _vatPercentage = 0.15M;
                    }
                    if (UtilityService.PaymentsMustBeVatInclusive)
                    { // total paid will include VAT
                        VATAmount = PaymentsFile.TotalPaid * _vatPercentage;
                        AmountExclVat = PaymentsFile.TotalPaid - PaymentsFile.VAT;
                        AmountInclVat = PaymentsFile.TotalPaid;
                        PaymentsFile.VAT = (TransactionState.Positive == transactionState) ? VATAmount : (VATAmount * -1);
                        PaymentsFile.AmountExclVAT = (TransactionState.Positive == transactionState) ? AmountExclVat : (AmountExclVat * -1);
                        PaymentsFile.Amount = (TransactionState.Positive == transactionState) ? AmountInclVat : (AmountInclVat * -1);

                    }
                    else
                    {

                        // total paid is VAT exclusive so we need to calculate total with VAT
                        VATAmount = PaymentsFile.TotalPaid * _vatPercentage;
                        AmountInclVat = PaymentsFile.VAT + PaymentsFile.TotalPaid;
                        AmountExclVat = PaymentsFile.TotalPaid;
                        PaymentsFile.VAT = (TransactionState.Positive == transactionState) ? VATAmount : (VATAmount * -1);
                        PaymentsFile.AmountExclVAT = (TransactionState.Positive == transactionState) ? AmountExclVat : (AmountExclVat * -1);
                        PaymentsFile.Amount = (TransactionState.Positive == transactionState) ? AmountInclVat : (AmountInclVat * -1); ;
                    }
                    PaymentsFile.TransRef = UtilityService.GenerateTransactionRef(PaymentsFile.Client.AccountNumber.ToString());
                    PaymentsFile.TransactionTypeID = (int)transaction;
                    PaymentsFile.PaymentStatusID = (int)PaymentState.Paid;
                    PaymentsFile.LastChangedBy = UtilityService.CurrentUserName;
                    PaymentsFile.LastChangedDate = DateTime.Now;
                    _context.Add(PaymentsFile);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> ReversePayment(Transaction PaymentsFile, TransactionTypeList transaction)
        {// create a duplicate negative payment with  new transactions
            int transactionID = PaymentsFile.TransactionID;
            int oldPaymentStatus = (int)PaymentState.Reversed;

                         try
            {

                TransactionState transactionState = GetTransactionState(PaymentsFile.TransactionTypeID);
                // with reversal if the transaction was a positive it becomes a negative and negative becomes positive
                decimal VATAmount = 0m;
                decimal AmountExclVat = 0m;
                decimal AmountInclVat = 0m;
                VATAmount = PaymentsFile.VAT;
                AmountExclVat = PaymentsFile.AmountExclVAT;
                AmountInclVat = PaymentsFile.Amount;
                Transaction newPaymentFile = new Transaction
                {
                    TransRef = UtilityService.GenerateTransactionRef(PaymentsFile.Client.AccountNumber),
                    ClientID = PaymentsFile.ClientID,
                    ProductID = PaymentsFile.ProductID,
                    PaymentDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                    Year = DateTime.Now.Year,
                    Month = DateTime.Now.Month,
                    Amount = (TransactionState.Positive == transactionState) ? (AmountInclVat * -1) : AmountInclVat,
                    VAT = (TransactionState.Positive == transactionState) ? (VATAmount * -1) : VATAmount,
                    AmountExclVAT = (TransactionState.Positive == transactionState) ? (AmountExclVat * -1) : AmountExclVat,
                    ParentPaymentID = transactionID,
                    LastChangedBy = UtilityService.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                    TransactionTypeID = (int)transaction,
                    PaymentStatusID = (int)PaymentState.Paid,
                    BankAccountID = PaymentsFile.BankAccountID
                };
                _context.Add(newPaymentFile);

                updateOldPayment(transactionID, oldPaymentStatus);

            }
            catch (Exception ex)
            {

                throw;
            }

            //}

            return await _context.SaveChangesAsync();
        }


        private void updateOldPayment(int transactionID, int oldPaymentStatus)
        {

            try
            {
                //update status of old payment
                Transaction oldPaymentsFile = _context.Transactions.Find(transactionID);
                oldPaymentsFile.LastChangedBy = UtilityService.CurrentUserName;
                oldPaymentsFile.LastChangedDate = DateTime.Now;
                oldPaymentsFile.PaymentStatusID = oldPaymentStatus;
                _context.Update(oldPaymentsFile);
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public async Task<List<Transaction>> ClientTransactions(int ClientID)
        {
            return await _context.Transactions.Where(p => p.ClientID == ClientID)
             .Include(p => p.Client)
             .Include(p => p.Product)
                           .Include(p => p.PaymentStatus)
              .Include(p => p.TransactionType)
               .ThenInclude(p => p.TransactionStatus)
              .Include(p => p.BankAccount)
             .OrderByDescending(t => t.TransactionDate)
             .AsNoTracking()
             .ToListAsync();
        }
        public async Task<List<Transaction>> Transactions()
        {
            return await _context.Transactions
              .Include(p => p.Client)
             .Include(p => p.Product)
                        .Include(p => p.PaymentStatus)
              .Include(p => p.TransactionType)
              .ThenInclude(p => p.TransactionStatus)
               .Include(p => p.BankAccount)
             .AsNoTracking()
             .ToListAsync();
        }
        public async Task<long> NewPayments()
        {
            return await _context.Transactions
            .Include(p => p.Client)
             .Include(p => p.Client)
             .Include(p => p.Product)
             .Include(p => p.PaymentStatus)
             .Include(p => p.TransactionType)
             .ThenInclude(p => p.TransactionStatus)
             .Include(p => p.BankAccount)
            .Where(p => p.TransactionDate.Date == DateTime.Now.Date)
            .AsNoTracking()
            .LongCountAsync();
        }

        public async Task<Transaction> PaymentFile(int TransactionID, string TranRef)
        {
            if (!String.IsNullOrEmpty(TranRef))
                TransactionID = _context.Transactions
                            .FirstOrDefault(p => p.TransRef.ToUpper() == TranRef.Trim().ToUpper())?.TransactionID ?? 0;
            return await _context.Transactions
             .Include(p => p.Client)
             .Include(p => p.Product)
             .Include(p => p.PaymentStatus)
             .Include(p => p.TransactionType)
             .ThenInclude(p => p.TransactionStatus)
             .Include(p => p.BankAccount)
            .Where(t => t.TransactionID == TransactionID).FirstOrDefaultAsync();
        }



    }
}
