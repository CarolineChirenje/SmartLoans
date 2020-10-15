using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public class DashboardService : IDashboardService
    {
        private readonly DatabaseContext _context;

        public DashboardService(DatabaseContext context)
        {
            _context = context;

        }
        public int GetProductPayments()
        {
            return  _context.Transactions.Where(rp => rp.TransactionDate.Date >= DateTime.Now.AddDays(-1).Date && rp.TransactionDate.Date <= DateTime.Now.Date).Count();
        }

       
        public int GetNewClientRegistrations()
        {
            return  _context.Clients.Where(rp => rp.RegistrationDate.Date >= DateTime.Now.AddDays(-1).Date && rp.RegistrationDate.Date <= DateTime.Now.Date).Count(); 
        }


        public int GetNewCourses()
        {
            return _context.Courses.Where(c => c.DateCreated.Date >= DateTime.Now.AddDays(-1).Date && c.DateCreated.Date <= DateTime.Now.Date).Count();
        }
        public int GetOpenNotices()
        {
            return _context.NoticeBoard.
            Where(r =>
               r.IsActive && (r.StartDate.Date > DateTime.Now.AddDays(-8).Date && r.EndDate.Date < DateTime.Now.AddDays(8).Date)).Count();

        }
    }
}
