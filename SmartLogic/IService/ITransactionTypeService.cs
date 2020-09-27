using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface ITransactionTypeService
    {
        Task<int> Delete(int id);
        Task<int> Save(TransactionType TransactionType);
        Task<int> Update(TransactionType TransactionType);
        Task<int> ActionTransactionType(int id, DatabaseAction action);
        Task<TransactionType> FindTransactionType(int id);
        Task<List<TransactionType>> TransactionType();
        Task<List<TransactionStatus>> TransactionStatus();
        Task<TransactionStatus> FindTransactionStatus(int id);
    }
        
}
