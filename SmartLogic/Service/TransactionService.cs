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
        public async Task<int> CreatePayment(Transaction PaymentsFile, TransactionType transaction)
        {
            PaymentsFile.Year = DateTime.Now.Year;
            PaymentsFile.Month = DateTime.Now.Month;
            PaymentsFile.TransactionDate = DateTime.Now;
            switch (transaction)
            {
                case TransactionType.Payment:


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
                        decimal _discountInclusiveTotal = PaymentsFile.TotalPaid + PaymentsFile.Discount;
                        PaymentsFile.VAT = PaymentsFile.TotalPaid * _vatPercentage;
                        PaymentsFile.AmountExclVAT = PaymentsFile.TotalPaid - PaymentsFile.VAT;
                        PaymentsFile.Amount = _discountInclusiveTotal;

                    }
                    else
                    {

                        // total paid is VAT exclusive so we need to calculate total with VAT
                        PaymentsFile.VAT = PaymentsFile.TotalPaid * _vatPercentage;
                        decimal _VATInclusiveTotal = PaymentsFile.VAT + PaymentsFile.TotalPaid;
                        PaymentsFile.AmountExclVAT = PaymentsFile.TotalPaid;
                        PaymentsFile.Amount = _VATInclusiveTotal + PaymentsFile.Discount;
                    }
                    PaymentsFile.TransRef = UtilityService.GenerateTransactionRef(PaymentsFile.Client.AccountNumber.ToString());
                    PaymentsFile.TransactionTypeID = (int)transaction;
                    PaymentsFile.PaymentStatusID = (int)PaymentState.Paid;
                    PaymentsFile.LastChangedBy = UtilityService.CurrentUserName;
                    PaymentsFile.LastChangedDate = DateTime.Now;
                    _context.Add(PaymentsFile);

                    break;
                case TransactionType.Reversal:
                case TransactionType.Refund:
                case TransactionType.Void:
                    UpdatePayment(PaymentsFile, transaction);
                    break;
                default:
                    break;
            }
            return (await _context.SaveChangesAsync());
        }


        void UpdatePayment(Transaction PaymentsFile, TransactionType transaction)
        {// create a duplicate negative payment with  new transactions
            int transactionID = PaymentsFile.TransactionID;
            int oldPaymentStatus = 0;

            if (transaction == TransactionType.Void)
            {

                oldPaymentStatus = (int)PaymentState.Pending;
                updateOldPayment(transactionID, oldPaymentStatus);
            }

            else
            {

                switch (transaction)
                {

                    case TransactionType.Reversal:
                        oldPaymentStatus = (int)PaymentState.Reversed;

                        break;
                    case TransactionType.Refund:
                        oldPaymentStatus = (int)PaymentState.Refunded;

                        break;

                    case TransactionType.Discount:
                        oldPaymentStatus = (int)PaymentState.Discounted;

                        break;
                    default:
                        break;
                }
                oldPaymentStatus = (int)PaymentState.Reversed;
                try
                {
                    Transaction newPaymentFile = new Transaction
                    {
                        TransRef = UtilityService.GenerateTransactionRef(PaymentsFile.Client.AccountNumber),
                        ClientID = PaymentsFile.ClientID,
                        ProductID = PaymentsFile.ProductID,
                        PaymentDate = DateTime.Now,
                        TransactionDate = DateTime.Now,
                        Year = DateTime.Now.Year,
                        Month = DateTime.Now.Month,
                        Amount = PaymentsFile.Amount * -1,
                        VAT = PaymentsFile.VAT * -1,
                        AmountExclVAT = PaymentsFile.AmountExclVAT * -1,
                        Discount = PaymentsFile.Discount * -1,
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

            }


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
              .Include(p => p.TransactionTypes)
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
              .Include(p => p.TransactionTypes)
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
             .Include(p => p.TransactionTypes)
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
             .Include(p => p.TransactionTypes)
             .Include(p => p.BankAccount)
            .Where(t => t.TransactionID == TransactionID).FirstOrDefaultAsync();
        }

    }
}
