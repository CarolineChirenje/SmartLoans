using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface ITransactionService 
    {
        Task<Transaction> PaymentFile(int TransactionID, string TranRef=null);
        Task<int> CreatePayment(Transaction PaymentsFile, TransactionTypeList transaction);
        Task<int> ReversePayment(Transaction PaymentsFile, TransactionTypeList transaction);
        
        Task<List<Transaction>> ClientTransactions(int ClientID);
        Task<List<Transaction>> Transactions();
        Task<long> NewPayments();
        Task<int> CalculateDeductions(List<int> ClientProductIDs, DateTime CutOffDate);
        Task<List<ClientDeduction>> GetClientDeductions(List<int> ClientProductIDs, DateTime CutOffDate);
    }

}
