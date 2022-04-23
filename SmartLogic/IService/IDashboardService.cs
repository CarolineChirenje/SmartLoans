using SmartDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface IDashboardService
    {
        int GetNewClientRegistrations();

        int GetClientWithLoans();
        int GetClientWithOutLoans();
        int GetNewLoans();
        int GetProductPayments();
        int GetOpenNotices();

        int GetBirthdays();
        List<UserToDo> GetUserToDoList();
    }
}
