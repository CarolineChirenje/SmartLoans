using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface ITransactionService
    {
        Task<Transaction> PaymentFile(int TransactionID, string TranRef = null);
        Task<int> CreatePayment(Transaction PaymentsFile, TransactionTypeList transaction);
        Task<int> ReversePayment(Transaction PaymentsFile, TransactionTypeList transaction);

        Task<List<Transaction>> ClientTransactions(int ClientID);
        Task<List<Transaction>> Transactions();
        Task<long> NewPayments();
        Task<int> RemoveInvoice(int invoiceID);
        Task<int> CalculateDeductions(List<int> ClientProductIDs, int ClientDeductionID);
        Task<int> RemoveInvoiceEntries(List<int> clientDeductionsDetails);
        Task<int> CreateInvoice(DateTime InvoiceDate, DateTime DueDate, int? productID);
        bool InvoiceHasEntries(int invoiceID);
        List<ClientDeduction> GetSchedule(DateTime DateFrom, DateTime DateTo);
     InvoiceDetails GetSchedule(int clientDeductionID);
        ClientDeduction GetClientDeductionSchedule(int clientDeductionID);
        bool DeductionExists(DateTime dueDate, DateTime invoiceDate);
        Task<List<ClientDeductionDetails>> GetClientDeductions(List<int> ClientProductIDs, DateTime InvoiceDate);
    }

}
