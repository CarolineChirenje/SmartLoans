using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
  public  interface IMaintananceService
    {
        Task<int> Delete(int id);
        Task<int> Save(Maintanance Maintanance);
        Task<int> Update(Maintanance Maintanance);
        Task<int> ActionMaintanance(int id, DatabaseAction action);
        Task<Maintanance> FindMaintanance(int id);
        Task<List<Maintanance>> Maintanance();
        Maintanance FindActiveMaintanance();
    }
}
