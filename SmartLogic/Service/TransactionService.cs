﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartDataAccess;
using SmartHelper;
using SmartDomain;
using System.Globalization;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore.Internal;
using SmartLog;

namespace SmartLogic
{

    public class TransactionService : ITransactionService
    {
        private readonly DatabaseContext _context;
        public TransactionService(DatabaseContext context) => _context = context;
        public TransactionService()
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                optionsBuilder.UseSqlServer(GetData.SSDBConnection);
                _context = new DatabaseContext(optionsBuilder.Options);
            }

        }
        TransactionState GetTransactionState(int TransactionTypeID)
        {
            try
            {

                var transactionType = _context.TransactionType.Find(TransactionTypeID);
                TransactionState transactionState = (TransactionState)transactionType.TransactionStatusID;
                return transactionState;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> CreatePayment(Transaction PaymentsFile, TransactionTypeList transaction)
        {
            try
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

                PaymentsFile.TransRef = NewTransactionRef;
                PaymentsFile.TransactionTypeID = (int)transaction;
                PaymentsFile.PaymentStatusID = (int)PaymentState.Paid;
                PaymentsFile.LastChangedBy = UtilityService.CurrentUserName;
                PaymentsFile.LastChangedDate = DateTime.Now;
                _context.Add(PaymentsFile);
                await _context.SaveChangesAsync();
                return PaymentsFile.TransactionID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        #region TransactionRef
        public string NewTransactionRef
        {
            get
            {
                return GenerateTransactionRef();
            }
        }
        private bool TransRefExists(string transRef)
        {
            try
            {
                return _context.Transactions.Any(t => t.TransRef.Equals(transRef));
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        string GenerateTransactionRef()
        {
            try
            {
                string queryRef = $"T{DateTime.Now.Year.ToString()}{ DateTime.Now.ToString("MM").ToUpper()}{ DateTime.Now.ToString("dd").ToUpper()}{UtilityService.GenerateRandomNumbers(2)}";
                queryRef.ToUpper();
                if (TransRefExists(queryRef))
                    return GenerateTransactionRef();

                else
                    return queryRef;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        #endregion TransactionRef

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
                    TransRef = NewTransactionRef,
                    ClientID = PaymentsFile.ClientID,
                    PaymentDate = DateTime.Now,
                    TransactionDate = DateTime.Now,
                    Year = DateTime.Now.Year,
                    Month = DateTime.Now.Month,
                    ParentPaymentID = transactionID,
                    LastChangedBy = UtilityService.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                    TransactionTypeID = (int)transaction,
                    PaymentStatusID = (int)PaymentState.Reversed,
                    BankAccountID = PaymentsFile.BankAccountID,
                    AssertCategoryID = PaymentsFile.AssertCategoryID,
                    AssertID = PaymentsFile.AssertID
                };
                if (PaymentsFile.ProductID.HasValue)
                    newPaymentFile.ProductID = PaymentsFile.ProductID;

                if (PaymentsFile.CourseID.HasValue)
                    newPaymentFile.CourseID = PaymentsFile.CourseID;

                newPaymentFile.Amount = (AmountInclVat * -1);
                newPaymentFile.VAT = (VATAmount * -1);
                newPaymentFile.AmountExclVAT = (AmountExclVat * -1);
                newPaymentFile.Narration = $"(R) - {PaymentsFile.TransRef}";
                _context.Add(newPaymentFile);
                await _context.SaveChangesAsync();
                int ReversalPaymentID = newPaymentFile.TransactionID;
                updateOldPayment(transactionID, oldPaymentStatus, newPaymentFile.TransRef, ReversalPaymentID);

                if (PaymentsFile.ClientFeeID.HasValue)
                {
                    ClientFee clientFee = _context.ClientFees.Find(PaymentsFile.ClientFeeID);
                    if (UtilityService.IsNotNull(clientFee))
                    {
                        clientFee.DatePaid = null;
                        clientFee.LastChangedBy = UtilityService.CurrentUserName;
                        clientFee.LastChangedDate = DateTime.Now;
                        _context.Update(clientFee);

                    }
                }

            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
            }
            return await _context.SaveChangesAsync();
        }
        private void updateOldPayment(int transactionID, int oldPaymentStatus, string newTransRef, int reversalPaymentID)
        {
            try
            {
                //update status of old payment
                Transaction oldPaymentsFile = _context.Transactions.Find(transactionID);
                string old_Narration = oldPaymentsFile.Narration;
                string append_Narration = $"(R) - {newTransRef}.";
                oldPaymentsFile.LastChangedBy = UtilityService.CurrentUserName;
                oldPaymentsFile.LastChangedDate = DateTime.Now;
                oldPaymentsFile.PaymentStatusID = oldPaymentStatus;
                oldPaymentsFile.ReversalPaymentID = reversalPaymentID;
                oldPaymentsFile.Narration = String.IsNullOrEmpty(old_Narration) ? append_Narration : $"{old_Narration} : {append_Narration}";
                _context.Update(oldPaymentsFile);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<List<Transaction>> ClientTransactions(int ClientID)
        {
            try
            {
                return await _context.Transactions.Where(p => p.ClientID == ClientID)
                  .Include(p => p.Client)
                  .Include(p => p.Product)
                  .Include(p => p.Course)
                  .Include(p => p.PaymentStatus)
                   .Include(p => p.TransactionType)
                    .ThenInclude(p => p.TransactionStatus)
                   .Include(p => p.BankAccount)
                  .OrderByDescending(t => t.TransactionDate)
                  .AsNoTracking()
                  .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<List<Transaction>> Transactions()
        {
            try
            {
                return await _context.Transactions
                  .Include(p => p.Client)
                 .Include(p => p.Product)
                 .Include(p => p.Course)
                  .Include(p => p.PaymentStatus)
                  .Include(p => p.TransactionType)
                  .ThenInclude(p => p.TransactionStatus)
                   .Include(p => p.BankAccount)
                 .AsNoTracking()
                 .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<long> NewPayments()
        {
            try
            {
                return await _context.Transactions
                .Include(p => p.Client)
                 .Include(p => p.Client)
                 .Include(p => p.Product)
                 .Include(p => p.Course)
                 .Include(p => p.PaymentStatus)
                 .Include(p => p.TransactionType)
                 .ThenInclude(p => p.TransactionStatus)
                 .Include(p => p.BankAccount)
                .Where(p => p.TransactionDate.Date == DateTime.Now.Date)
                .AsNoTracking()
                .LongCountAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<Transaction> PaymentFile(int TransactionID, string TranRef)
        {
            try
            {
                if (!String.IsNullOrEmpty(TranRef))
                    TransactionID = _context.Transactions
                                .FirstOrDefault(p => p.TransRef.ToUpper() == TranRef.Trim().ToUpper())?.TransactionID ?? 0;
                return await _context.Transactions
                 .Include(p => p.Client)
                 .Include(p => p.Product)
                 .Include(p => p.Course)
                 .Include(p => p.PaymentStatus)
                 .Include(p => p.TransactionType)
                 .ThenInclude(p => p.TransactionStatus)
                 .Include(p => p.BankAccount)
                .Where(t => t.TransactionID == TransactionID).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        #region Invoices

        public bool InvoiceEntriesIsDuplicate(int invoiceID)
        {
            try
            {
                bool entriesExists = false;
                entriesExists = _context.InvoiceDetails
                             .Any(cd => cd.InvoiceID == invoiceID);
                return entriesExists;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public bool InvoiceIsDuplicate(DateTime dueDate, DateTime invoiceDate, int? productID = null)
        {
            try
            {
                bool invoiceExists = false;
                if (productID.HasValue)
                {
                    if (productID.Value > 0)
                    {
                        invoiceExists = _context.Invoices
                          .Any(cd => cd.DueDate == dueDate && cd.InvoiceDate == invoiceDate && cd.ProductID.Value == productID.Value);
                        return invoiceExists;
                    }
                    if (productID.Value == 0)
                    {
                        invoiceExists = _context.Invoices
                             .Any(cd => cd.DueDate == dueDate && cd.InvoiceDate == invoiceDate && (!cd.ProductID.HasValue || cd.ProductID.Value == 0));
                        return invoiceExists;
                    }
                }
                else
                    invoiceExists = _context.Invoices
                             .Any(cd => cd.DueDate == dueDate && cd.InvoiceDate == invoiceDate);
                return invoiceExists;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public InvoiceState GetInvoiceStatus(int InvoiceID)
        {
            var clientDeduction = _context.Invoices
                    .FirstOrDefault(cd => cd.InvoiceID == InvoiceID);
            InvoiceState invoiceState = InvoiceState.Unknown;
            if (UtilityService.IsNotNull(clientDeduction))
                invoiceState = (InvoiceState)clientDeduction.InvoiceStatusID;

            return invoiceState;
        }
        public async Task<int> RemoveInvoiceEntries(List<int> InvoiceDetails)
        {
            var clientDeductions = _context.InvoiceDetails.Where(cd => InvoiceDetails.Contains(cd.InvoiceDetailID));
            _context.RemoveRange(clientDeductions);
            return await _context.SaveChangesAsync();
        }
        public bool InvoiceHasEntries(int InvoiceID)
        {
            var hasEntries = _context.InvoiceDetails.Any(cd => cd.InvoiceID == InvoiceID);
            return hasEntries;
        }
        public int RemoveInvoice(int InvoiceID)
        {
            var deduction = _context.Invoices.Where(cd => cd.InvoiceID == InvoiceID).FirstOrDefault();
            _context.Remove(deduction);
            return _context.SaveChanges();
        }
        public int FinaliseInvoice(int InvoiceID)
        {
            try
            {
                int result = 0;
                Invoice update = _context.Invoices.
                Where(t => t.InvoiceID == InvoiceID).FirstOrDefault();
                if (UtilityService.IsNotNull(update))
                {
                    update.InvoiceStatusID = (int)InvoiceState.Finalised;
                    update.LastChangedBy = UtilityService.CurrentUserName;
                    update.LastChangedDate = DateTime.Now;
                    _context.Entry(update).State = EntityState.Modified;
                    result = _context.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> CreateInvoice(DateTime InvoiceDate, DateTime DueDate, int? ProductID)
        {
            try
            {
                int result = 0;
                Invoice deduction = new Invoice
                {
                    InvoiceDate = InvoiceDate,
                    DueDate = DueDate,
                    LastChangedBy = UtilityService.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                    InvoiceStatusID = (int)InvoiceState.Created,

                };
                if (ProductID.HasValue)
                {
                    if (ProductID.Value > 0)
                        deduction.ProductID = ProductID.Value;
                }
                _context.Add(deduction);
                result = await _context.SaveChangesAsync();
                return deduction.InvoiceID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public int ProcessInvoice(List<int> ClientProductIDs, int InvoiceID)
        {
            try
            {
                int result = 0;

                var clientProduct = _context.ClientProducts.
                    Include(c => c.Product).
                       Include(c => c.Client).
                       ThenInclude(c => c.ClientOccupationHistory).
                       Where(t => ClientProductIDs.Contains(t.ClientProductID)).ToList();

                if (UtilityService.IsNotNull(clientProduct) && clientProduct.Count() > 0)
                {
                    foreach (var item in clientProduct)
                    {
                        if (!item.DoNotDeduct) //only deduct if do not deduct is set to false
                        {
                            //1.
                            decimal _percentageDeduction = item.DeductionPercentage.HasValue ? item.DeductionPercentage.Value : item.Product.DeductionPercentage;
                            decimal _percentageIncrement = item.IncreamentPercentage.HasValue ? item.IncreamentPercentage.Value : item.Product.IncreamentPercentage;
                            decimal _currentSalary = item.Client.Salary;
                            decimal? _previousSalary = null;
                            decimal _totalDeductionPercentage = 0M;
                            decimal _totalDeduction = 0M;
                            var _lastSalary = item.Client.ClientOccupationHistory.OrderByDescending(oh => oh.Occupation).FirstOrDefault();
                            if (UtilityService.IsNotNull(_lastSalary))
                                _previousSalary = _lastSalary.Salary;

                            if (_previousSalary.HasValue)
                            {
                                if (_currentSalary > _previousSalary.Value)
                                    _totalDeductionPercentage = _percentageDeduction + _percentageIncrement;
                                else
                                    _totalDeductionPercentage = _percentageDeduction;
                            }
                            else
                                _totalDeductionPercentage = _percentageDeduction;
                            _totalDeduction = _currentSalary * (_totalDeductionPercentage / 100M);
                            InvoiceDetails deductionDetails = new InvoiceDetails
                            {
                                ClientID = item.ClientID,
                                ClientProductID = item.ClientProductID,
                                Salary = _currentSalary,
                                ProductID = item.ProductID,
                                InvoiceID = InvoiceID,
                                DeductedAmount = _totalDeduction,
                                TotalDeductionPercentage = _totalDeductionPercentage,
                                DeductionPercentage = _percentageDeduction,
                                AdditionalDeductionPercentage = _percentageIncrement,
                                LastChangedBy = UtilityService.CurrentUserName,
                                LastChangedDate = DateTime.Now,
                                InvoiceNumber = $"{item.Client.AccountNumber}-INV-{InvoiceID}"

                            };
                            _context.Add(deductionDetails);
                        }
                    }
                    if (clientProduct.Count() > 0)
                        result = _context.SaveChanges();
                    if (result > 0)
                    {
                        try
                        {
                            Invoice update = _context.Invoices.
                            Where(t => t.InvoiceID == InvoiceID).FirstOrDefault();
                            if (UtilityService.IsNotNull(update))
                            {
                                update.InvoiceStatusID = (int)InvoiceState.Processed;
                                update.LastChangedBy = UtilityService.CurrentUserName;
                                update.LastChangedDate = DateTime.Now;
                                _context.Entry(update).State = EntityState.Modified;
                                return _context.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            CustomLog.Log(LogSource.Logic_Base, ex);
                            throw;
                        }
                    }
                }
                result = InvoiceID;
                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw ex;
            }
        }
        public async Task<List<InvoiceDetails>> GetInvoiceDetails(List<int> ClientProductIDs, DateTime InvoiceDate)
        {
            try
            {
                return await _context.InvoiceDetails
                .Include(c => c.Invoice)
                  .Include(p => p.Client)
                  .ThenInclude(p => p.ClientGroup)
                  .Include(p => p.Client)
                  .ThenInclude(p => p.Company)
                    .Include(p => p.Product)
                   .Where(t => t.Invoice.InvoiceDate == InvoiceDate && ClientProductIDs.Contains(t.ClientProductID)).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<Invoice> GetInvoices(DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                var deductions = _context.Invoices
                .Include(c => c.InvoiceDetails)
                 .Where(cd => cd.InvoiceDate >= DateFrom && cd.InvoiceDate <= DateTo).ToList();
                return deductions;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public InvoiceDetail GetInvoiceDetail(int invoiceID)
        {
            try
            {
                var deductions = _context.InvoiceDetails
                .Include(c => c.Invoice)
                .Include(p => p.Client)
                  .ThenInclude(p => p.ClientGroup)
                  .Include(p => p.Client)
                  .ThenInclude(p => p.Company)
                    .Include(p => p.Product)
                 .Where(cd => cd.InvoiceID == invoiceID).ToList();

                InvoiceDetail invoice = new InvoiceDetail();
                invoice.InvoiceDetails = deductions;
                invoice.State = GetInvoiceStatus(invoiceID);
                invoice.InvoiceID = invoiceID;
                return invoice;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public Invoice GetInvoice(int invoiceID)
        {
            try
            {
                var deductions = _context.Invoices
                  .Include(c => c.InvoiceDetails)
                  .ThenInclude(c => c.Client)
                  .ThenInclude(c => c.Title)
                   .Include(c => c.InvoiceDetails)
                   .ThenInclude(c => c.Client)
                  .ThenInclude(c => c.JointApplicant)
                  .ThenInclude(c => c.Title)
                   .Include(c => c.InvoiceDetails)
                   .ThenInclude(c => c.Product)
                   .Where(cd => cd.InvoiceID == invoiceID).FirstOrDefault();
                return deductions;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        #endregion Invoices
    }
}
