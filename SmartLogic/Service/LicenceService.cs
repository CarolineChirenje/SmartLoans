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
    public class LicenceService : ILicenceService
    {
        private readonly DatabaseContext _context;

        public LicenceService(DatabaseContext context) => _context = context;
        public async Task<int> ActionLicence(int id, DatabaseAction action)
        {
            try
            {

                Licence Licence = await FindLicence(id);

                if (DatabaseAction.Remove == action)
                    _context.Licences.Remove(Licence);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                     Licence.LastChangedBy = UserAppData.CurrentUserName;
                    Licence.LastChangedDate = DateTime.Now;
                    _context.Update(Licence);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Licence>> Licence()
        {
            try
            {

                return await _context.Licences
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

                var course = await _context.Licences.FindAsync(id);
                _context.Licences.Remove(course);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<Licence> FindLicence(int id)
        {
            try
            {

                return await _context.Licences.Where(r => r.LicenceID == id)
.AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public Licence FindActiveLicence()
        {
            try
            {
                DateTime currentDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                Licence Licence = _context.Licences.Where(m => m.StartDate <= currentDate && m.EndDate<= currentDate).FirstOrDefault(); ;
                return Licence;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Licence Licence)
        {
            try
            {
                Licence.LastChangedBy = UserAppData.CurrentUserName;
                Licence.LastChangedDate = DateTime.Now;
                _context.Add(Licence);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> Update(Licence Licence)
        {
            try
            {

                Licence update = await FindLicence(Licence.LicenceID);
                update.StartDate = Licence.StartDate;
                update.EndDate = Licence.EndDate;
                              update.LastChangedBy = UserAppData.CurrentUserName;
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
