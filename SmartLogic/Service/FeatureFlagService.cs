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
using SmartExtensions;

namespace SmartLogic
{
    public class FeatureFlagService : IFeatureFlagService
    {
        private readonly DatabaseContext _context;

        public FeatureFlagService(DatabaseContext context) => _context = context;
        public async Task<int> ActionFeatureFlag(int id, DatabaseAction action)
        {
            try
            {

                        FeatureFlag FeatureFlag = await FindFeatureFlag(id);

            if (DatabaseAction.Remove == action)
                _context.FeatureFlags.Remove(FeatureFlag);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                FeatureFlag.IsActive = DatabaseAction.Deactivate == action ? false : true;
                FeatureFlag.LastChangedBy = UserAppData.CurrentUserName;
                FeatureFlag.LastChangedDate = DateTime.Now;
                _context.Update(FeatureFlag);
            }

            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<FeatureFlag>> FeatureFlag()
        {
            try
            {

                        return await _context.FeatureFlags
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

                        var course = await _context.FeatureFlags.FindAsync(id);
            _context.FeatureFlags.Remove(course);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<FeatureFlag> FindFeatureFlag(int id)
        {
            try
            {

                       return await _context.FeatureFlags.Where(r => r.FeatureFlagID == id)
 .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public bool FeatureIsSwitchedOn(int id)
        {
            try
            {

           FeatureFlag featureFlag =  FindFeatureFlag(id).Result;
            if (featureFlag.IsNotNull())
                return featureFlag.IsActive;
            else
                return false;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(FeatureFlag FeatureFlag)
        {
            try
            {

                        FeatureFlag.LastChangedBy = UserAppData.CurrentUserName;
            FeatureFlag.LastChangedDate = DateTime.Now;
            _context.Add(FeatureFlag);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

      
        public async Task<int> Update(FeatureFlag FeatureFlag)
        {
            try
            {

                        FeatureFlag update = await FindFeatureFlag(FeatureFlag.FeatureFlagID);
            update.Name = FeatureFlag.Name;
            update.IsActive = FeatureFlag.IsActive;
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
