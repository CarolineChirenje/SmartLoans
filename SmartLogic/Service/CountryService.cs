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
    public class CountryService : ICountryService
    {
        private readonly DatabaseContext _context;

        public CountryService(DatabaseContext context) => _context = context;
        public async Task<int> ActionCountry(int id, DatabaseAction action)
        {
            try
            {
            Country Country = await FindCountry(id);

            if (DatabaseAction.Remove == action)
                _context.Countries.Remove(Country);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Country.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Country.LastChangedBy = UserAppData.CurrentUserName;
                Country.LastChangedDate = DateTime.Now;
                _context.Update(Country);
            }

            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Country>> Country()
        {
            try
            {
            return await _context.Countries
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

                       var course = await _context.Countries.FindAsync(id);
            _context.Countries.Remove(course);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<Country> FindCountry(int id)
        {
            try
            {
            return await _context.Countries.Where(r => r.CountryID == id)
 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(Country Country)
        {
            try
            {

            Country.LastChangedBy = UserAppData.CurrentUserName;
            Country.LastChangedDate = DateTime.Now;
            _context.Add(Country);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

      
        public async Task<int> Update(Country Country)
        {
            try
            {

            Country update = await FindCountry(Country.CountryID);
            update.Name = Country.Name;
            update.IsActive = Country.IsActive;
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
