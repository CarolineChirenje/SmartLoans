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
    public class MaintananceService : IMaintananceService
    {
        private readonly DatabaseContext _context;

        public MaintananceService(DatabaseContext context) => _context = context;
        public async Task<int> ActionMaintanance(int id, DatabaseAction action)
        {
            try
            {

                Maintanance Maintanance = await FindMaintanance(id);

                if (DatabaseAction.Remove == action)
                    _context.Maintanances.Remove(Maintanance);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                     Maintanance.LastChangedBy = UtilityService.CurrentUserName;
                    Maintanance.LastChangedDate = DateTime.Now;
                    _context.Update(Maintanance);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Maintanance>> Maintanance()
        {
            try
            {

                return await _context.Maintanances
                .AsNoTracking()
    .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Delete(int id)
        {
            try
            {

                var course = await _context.Maintanances.FindAsync(id);
                _context.Maintanances.Remove(course);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<Maintanance> FindMaintanance(int id)
        {
            try
            {

                return await _context.Maintanances.Where(r => r.MaintananceID == id)
.AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public Maintanance FindActiveMaintanance()
        {
            try
            {
                DateTime currentDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                Maintanance Maintanance = _context.Maintanances.Where(m => m.StartDate <= currentDate && m.EndDate>= currentDate).FirstOrDefault(); ;
                return Maintanance;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Maintanance Maintanance)
        {
            try
            {
                Maintanance.LastChangedBy = UtilityService.CurrentUserName;
                Maintanance.LastChangedDate = DateTime.Now;
                _context.Add(Maintanance);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> Update(Maintanance Maintanance)
        {
            try
            {

                Maintanance update = await FindMaintanance(Maintanance.MaintananceID);
                update.StartDate = Maintanance.StartDate;
                update.EndDate = Maintanance.EndDate;
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
