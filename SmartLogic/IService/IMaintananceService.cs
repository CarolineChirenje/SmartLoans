using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
  public  interface ILicenceService
    {
        Task<int> Delete(int id);
        Task<int> Save(Licence Licence);
        Task<int> Update(Licence Licence);
        Task<int> ActionLicence(int id, DatabaseAction action);
        Task<Licence> FindLicence(int id);
        Task<List<Licence>> Licence();
        Licence FindActiveLicence();
    }
}
