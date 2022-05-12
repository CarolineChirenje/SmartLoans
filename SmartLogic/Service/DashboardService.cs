using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartLog;
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
            try
            {

                return _context.Transactions.Where(rp => rp.TransactionDate.Date >= DateTime.Now.AddDays(-1).Date && rp.TransactionDate.Date <= DateTime.Now.Date).Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        
         public int GetClientWithLoans()
        {
            try
            {

                return _context.Loans.Select(rp => rp.ClientID).Distinct().Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public int GetClientWithOutLoans()
        {
            try
            {
                int clients = _context.Clients.Count();
                int clientsWithLoans = GetClientWithLoans();
                int clientWithoutLoans = clients - clientsWithLoans;
                return clientWithoutLoans;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
     
        public int GetNewLoans()
        {
            try
            {

                return _context.Loans.Where(rp => rp.RegistrationDate.Date >= DateTime.Now.AddDays(-1).Date && rp.RegistrationDate.Date <= DateTime.Now.Date).Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public int GetNewClientRegistrations()
        {
            try
            {

                return _context.Clients.Where(rp => rp.RegistrationDate.Date >= DateTime.Now.AddDays(-1).Date && rp.RegistrationDate.Date <= DateTime.Now.Date).Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
      
         public int GetBirthdays()
        {
            try
            {

                return _context.Clients.ToList().Where(c=>c.DaysLeftToBirthday == 365 || c.DaysLeftToBirthday == 366).ToList().Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<UserToDo> GetUserToDoList()
        {
            try
            {
                return _context.UserToDos.Where(c => c.UserID==UserAppData.UserID).OrderBy(c=>c.DueDate).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public int GetOpenNotices()
        {
            try
            {
                  return _context.NoticeBoard.
                           Where(r =>
                              r.IsActive && (r.EndDate >= DateTime.Now)).Count();

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
    }
}
