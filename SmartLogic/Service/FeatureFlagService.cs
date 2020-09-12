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

namespace SmartLogic
{
    public class FeatureFlagService : IFeatureFlagService
    {
        private readonly DatabaseContext _context;

        public FeatureFlagService(DatabaseContext context) => _context = context;
        public async Task<int> ActionFeatureFlag(int id, DatabaseAction action)
        {
            FeatureFlag FeatureFlag = await FindFeatureFlag(id);

            if (DatabaseAction.Remove == action)
                _context.FeatureFlags.Remove(FeatureFlag);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                FeatureFlag.IsActive = DatabaseAction.Deactivate == action ? false : true;
                FeatureFlag.LastChangedBy = UtilityService.CurrentUserName;
                FeatureFlag.LastChangedDate = DateTime.Now;
                _context.Update(FeatureFlag);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<List<FeatureFlag>> FeatureFlag()
        {
            return await _context.FeatureFlags
                        .AsNoTracking()
            .ToListAsync();
        }

        public async Task<int> Delete(int id)
        {
            var course = await _context.FeatureFlags.FindAsync(id);
            _context.FeatureFlags.Remove(course);
            return (await _context.SaveChangesAsync());
        }

        public async Task<FeatureFlag> FindFeatureFlag(int id)
        {
            return await _context.FeatureFlags.Where(r => r.FeatureFlagID == id)
 .AsNoTracking().FirstOrDefaultAsync();
        }


        public bool FeatureIsSwitchedOn(int id)
        {
            FeatureFlag featureFlag =  FindFeatureFlag(id).Result;
            if (UtilityService.IsNotNull(featureFlag))
                return featureFlag.IsActive;
            else
                return false;


        }
        public async Task<int> Save(FeatureFlag FeatureFlag)
        {
            FeatureFlag.LastChangedBy = UtilityService.CurrentUserName;
            FeatureFlag.LastChangedDate = DateTime.Now;
            _context.Add(FeatureFlag);
            return (await _context.SaveChangesAsync());
        }

      
        public async Task<int> Update(FeatureFlag FeatureFlag)
        {
            FeatureFlag update = await FindFeatureFlag(FeatureFlag.FeatureFlagID);
            update.Name = FeatureFlag.Name;
            update.IsActive = FeatureFlag.IsActive;
                        update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(update);
            return await _context.SaveChangesAsync();
        }
    }
}
