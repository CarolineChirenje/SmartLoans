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
        Task<int> CalculateDeductions(List<int> ClientProductIDs, DateTime InvoiceDate, DateTime DueDate);
        Task<int> RemoveInvoiceEntries(List<int> clientDeductionsDetails);
        Task<int> RemoveInvoice(int invoiceID);
        bool InvoiceHasEntries(int invoiceID);
        List<ClientDeduction> GetSchedule(DateTime DateFrom, DateTime DateTo);
        List<ClientDeductionDetails> GetSchedule(int clientDeductionID);
        ClientDeduction GetClientDeductionSchedule(int clientDeductionID);
        bool DeductionExists(DateTime dueDate, DateTime invoiceDate);
        Task<List<ClientDeductionDetails>> GetClientDeductions(List<int> ClientProductIDs, DateTime InvoiceDate);
    }

}
