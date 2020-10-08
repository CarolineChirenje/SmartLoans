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
                    ParentPaymentID = transactionID,
                    LastChangedBy = UtilityService.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                    TransactionTypeID = (int)transaction,
                    PaymentStatusID = (int)PaymentState.Reversed,
                    BankAccountID = PaymentsFile.BankAccountID
                };

                newPaymentFile.Amount = (AmountInclVat * -1);
                newPaymentFile.VAT = (VATAmount * -1);
                newPaymentFile.AmountExclVAT = (AmountExclVat * -1);
                newPaymentFile.Narration = $"Reversal of  Transaction Ref - {PaymentsFile.TransRef}";
                _context.Add(newPaymentFile);

                updateOldPayment(transactionID, oldPaymentStatus, newPaymentFile.TransRef);

            }
            catch (Exception ex)
            {

                throw;
            }

            //}

            return await _context.SaveChangesAsync();
        }


        private void updateOldPayment(int transactionID, int oldPaymentStatus, string newTransRef)
        {

            try
            {
                //update status of old payment
                Transaction oldPaymentsFile = _context.Transactions.Find(transactionID);
                string old_Narration = oldPaymentsFile.Narration;
                string append_Narration = $"Transaction Reversed Refer to Trans Ref  {newTransRef}.";
                oldPaymentsFile.LastChangedBy = UtilityService.CurrentUserName;
                oldPaymentsFile.LastChangedDate = DateTime.Now;
                oldPaymentsFile.PaymentStatusID = oldPaymentStatus;
                oldPaymentsFile.Narration = String.IsNullOrEmpty(old_Narration) ? append_Narration : $"{old_Narration} : {append_Narration}";
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

        public async Task<int> CalculateDeductions(List<int> ClientProductIDs, DateTime CutOffDate)
        {
            int result = 0;
            var clientProduct = _context.ClientProducts.
                Include(c => c.Product).
                   Include(c => c.Client).
                   ThenInclude(c => c.ClientOccupationHistory).
                   Where(t => ClientProductIDs.Contains(t.ClientProductID)).ToList();

            foreach (var item in clientProduct)
            {
                //1.
                decimal _percentageDeduction = item.Product.DeductionPercentage;
                decimal _percentageIncrement = item.Product.IncreamentPercentage;
                decimal _currentSalary = item.Client.Salary;
                decimal _previousSalary = 0M;
                decimal _totalDeductionPercentage = 0M;
                decimal _totalDeduction = 0M;
                var _lastSalary = item.Client.ClientOccupationHistory.OrderByDescending(oh => oh.Occupation).FirstOrDefault();
                if (UtilityService.IsNotNull(_lastSalary))
                    _previousSalary = _lastSalary.Salary;

                if (_currentSalary > _previousSalary)
                    _totalDeductionPercentage = _percentageDeduction + _percentageIncrement;
                else
                    _totalDeductionPercentage = _percentageDeduction;

                _totalDeduction = _currentSalary * (_totalDeductionPercentage / 100M);

                ClientDeduction deduction = new ClientDeduction
                {
                    ClientID = item.ClientID,
                    ClientProductID=item.ClientProductID,
                    Salary = _currentSalary,
                    ProductID = item.ProductID,
                    DueDate = CutOffDate,
                    DeductedAmount=_totalDeduction,
                    TotalDeductionPercentage=_totalDeductionPercentage,
                    DeductionPercentage=_percentageDeduction,
                    AdditionalDeductionPercentage=_percentageIncrement,
                    LastChangedBy = UtilityService.CurrentUserName,
                    LastChangedDate = DateTime.Now,

                };

                _context.Add(deduction);
            }
            if (clientProduct.Count() > 0)
                result = await _context.SaveChangesAsync();

            return result;
        }

        public async Task<List<ClientDeduction>> GetClientDeductions(List<int> ClientProductIDs, DateTime CutOffDate)
        {
            return await _context.ClientDeductions
                .Include(p => p.Client)
                .Include(p => p.Product)

               .Where(t => ClientProductIDs.Contains(t.ClientProductID) && t.DueDate==CutOffDate).ToListAsync();

        }


    }
}
