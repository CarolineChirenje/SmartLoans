using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
  public  interface ICountryService
    {
        Task<int> Delete(int id);
        Task<int> Save(Country Country);
        Task<int> Update(Country Country);
        Task<int> ActionCountry(int id, DatabaseAction action);
        Task<Country> FindCountry(int id);
        Task<List<Country>> Country();
    }
}
