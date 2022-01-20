using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface IDashboardService
    {
        int GetNewClientRegistrations();
        int GetNewKhonapoFunds();
        int GetProductPayments();
        int GetOpenNotices();
        int GetNewCourses();
    }
}
