using SmartLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDomain;
using SmartDataAccess;
using SmartHelper;
using SmartLogic.IService;
using SmartLog;
using SmartExtensions;

namespace SmartLogic
{
    public class LogService : ILogService
    {
        private readonly DatabaseContext _context;
        public LogService(DatabaseContext context) => _context = context;
        public LogService()
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                optionsBuilder.UseSqlServer(GetData.SSDBConnection);
                _context = new DatabaseContext(optionsBuilder.Options);
            }
        }
        public void Log(Mail mail)
        {
            try
            {
                _context.Add(mail);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);

            }

        }

    }

}
