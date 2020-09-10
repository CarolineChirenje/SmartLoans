using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
  public  interface ICurrencyService
    {
        Task<int> Delete(int id);
        Task<int> Save(Currency Currency);
        Task<int> Update(Currency Currency);
        Task<int> ActionCurrency(int id, DatabaseAction action);
        Task<Currency> FindCurrency(int id);
        Task<List<Currency>> Currency();
    }
}
