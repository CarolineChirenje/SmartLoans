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
using SmartLog;

namespace SmartLogic
{
    public class SupportService : ISupportService
    {
        private readonly DatabaseContext _context;

        public SupportService(DatabaseContext context) => _context = context;
     
        public async Task<List<TechnicalSupport>> Support()
        {
            try
            {
                return await _context.TechnicalSupports
                    .AsNoTracking()
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<TechnicalSupport> FindSupport(int id)
        {
            try
            {
                return await _context.TechnicalSupports.Where(r => r.TechnicalSupportID == id)
                             .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> Update(TechnicalSupport Support)
        {
            try
            {
                TechnicalSupport update = await FindSupport(Support.TechnicalSupportID);
                 update.Value = Support.Value;
                update.LastChangedBy = UtilityService.CurrentUserName;
                 update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
    }
}
