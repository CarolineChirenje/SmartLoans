using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic.IService
{
   
      public interface IBankAccountservice
    {
        Task<int> Delete(int id);
        Task<int> Save(BankAccount bank);
        Task<bool> IsDuplicate(BankAccount bank);
        Task<int> Update(BankAccount bank);
        Task<int> ActionBank(int id, DatabaseAction action);
        Task<BankAccount> FindBank(int id);
        Task<List<BankAccount>> Banks();

    }
}
