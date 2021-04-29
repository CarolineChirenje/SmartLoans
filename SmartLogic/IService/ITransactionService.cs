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
        int RemoveInvoice(int invoiceID);
        int FinaliseInvoice(int invoiceID);
                 int ProcessInvoice(List<int> ClientProductIDs, int InvoiceID);
        Task<int> RemoveInvoiceEntries(List<int> invoiceDetailsID);
        Task<int> CreateInvoice(DateTime InvoiceDate, DateTime DueDate, int? productID);
        bool InvoiceHasEntries(int invoiceID);
        List<Invoice> GetInvoices(DateTime DateFrom, DateTime DateTo);
        InvoiceDetail GetInvoiceDetail(int invoiceID);
        Invoice GetInvoice(int invoiceID);
        bool InvoiceEntriesIsDuplicate(int invoiceID);
        bool InvoiceIsDuplicate(DateTime dueDate, DateTime invoiceDate, int? productID = null);
        Task<List<InvoiceDetails>> GetInvoiceDetails(List<int> ClientProductIDs, DateTime InvoiceDate);
    }

}
