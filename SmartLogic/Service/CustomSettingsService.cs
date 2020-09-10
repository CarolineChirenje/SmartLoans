
using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomSetting = SmartDomain.CustomSetting;

namespace SmartLogic
{
    public class CustomSettingsService : ICustomSettingsService
    {
        private  DatabaseContext _context;

        public CustomSettingsService(DatabaseContext context) => _context = context;

        public CustomSettingsService()
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                optionsBuilder.UseSqlServer(GetData.SSDBConnection);
                _context = new DatabaseContext(optionsBuilder.Options);
            }

        }

        public async Task<CustomSetting> FindCustomSetting(int id)
        {
            return await _context.CustomSettings.Where(r => r.CustomSettingID == id)
                           .AsNoTracking().FirstOrDefaultAsync();
        }
        CustomSetting GetCustomSetting(string name)
        {
            return _context.CustomSettings.
                Include(x => x.CustomVariableType).
                Include(x => x.CustomSettingType).
                Where(r => r.Name.ToUpper() == name.Trim().ToUpper()).
              AsNoTracking().FirstOrDefault();
        }


        public async Task<List<CustomSetting>> CustomSettings()
        {
            return await _context.CustomSettings.
              Include(x => x.CustomVariableType).
                Include(x => x.CustomSettingType)
                                .ToListAsync();
        }


        public List<CustomSetting> GetCustomSettings()
        {
            return _context.CustomSettings.
                 Include(x => x.CustomVariableType).
                Include(x => x.CustomSettingType)
                .ToList();
        }


        public async Task<int> Update(CustomSetting CustomSetting)
        {
            CustomSetting update = _context.CustomSettings.Where(r => r.CustomSettingID == CustomSetting.CustomSettingID)
                           .FirstOrDefault();

            if (UtilityService.IsNotNull(update)) // I'm using a extension method
            {
                update.Value = CustomSetting.Value;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            // check if local is not null 
           
                // detach
                _context.Entry(update).State = EntityState.Detached;
            }
            // set Modified flag in your entry
            _context.Entry(update).State = EntityState.Modified;

                    
          //  _context.Update(update);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Save(CustomSetting CustomSetting)
        {
            CustomSetting.IsActive = true;
            CustomSetting.LastChangedBy = UtilityService.CurrentUserName;
            CustomSetting.LastChangedDate = DateTime.Now;
            _context.Add(CustomSetting);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Delete(int id)
        {
            var CustomSetting = await _context.CustomSettings.FindAsync(id);
            _context.CustomSettings.Remove(CustomSetting);
            return (await _context.SaveChangesAsync());
        }

        public async Task<int> ActionCustomSetting(int id, DatabaseAction action)
        {
            CustomSetting CustomSetting = await FindCustomSetting(id);
            if (DatabaseAction.Remove == action)
                _context.CustomSettings.Remove(CustomSetting);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                CustomSetting.IsActive = DatabaseAction.Deactivate == action ? false : true;
                CustomSetting.LastChangedBy = UtilityService.CurrentUserName;
                CustomSetting.LastChangedDate = DateTime.Now;
                _context.Update(CustomSetting);
            }

            return (await _context.SaveChangesAsync());
        }


        public CustomSelectList GetCustomSetting(AppSetting applicationSetting)
        {
            try
            {
                          CustomSetting customSetting = _context.CustomSettings.Where(r => r.CustomSettingID == (int)applicationSetting)
                           .AsNoTracking().FirstOrDefault();
                                             return new CustomSelectList()
                                             {
                                                 ID = customSetting.CustomSettingID,
                                                 Name = customSetting.Value

                                             };
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string GetSettingValue(AppSetting applicationSetting)
        {

            CustomSelectList customSetting = GetCustomSetting(applicationSetting);

            if (UtilityService.IsNotNull(customSetting))
                return customSetting.Name;
            else
                return String.Empty;
        }
        public string GetCustomSettingValue(AppSetting applicationSetting, string value = null, bool isGet = true)
        {
            CustomSelectList customSetting;
            if (isGet)
            {
                customSetting = GetCustomSetting(applicationSetting);

            }
            else
            {
                customSetting = new CustomSelectList()
                {
                    ID = (int)applicationSetting,
                    Name = value
                };

            }

            if (String.IsNullOrEmpty(customSetting.Name))
                return null;
            //VariableType variableType = (VariableType)customSetting.ID;
            //if (variableType == VariableType.Integer)
            //{
            //    return Convert.ToInt32(customSetting.Name);
            //}
            //else if (variableType == VariableType.Boolean)
            //{
            //    return Convert.ToBoolean(customSetting.Name);
            //}
            //else if (variableType == VariableType.Double)
            //{
            //    return Convert.ToDouble(customSetting.Name);
            //}
            //else if (variableType == VariableType.Long)
            //{
            //    return Convert.ToInt64(customSetting.Name);
            //}
            //else if (variableType == VariableType.Date_Time)
            //{
            //    return Convert.ToDateTime(customSetting.Name).ToString(GetCustomSetting(applicationSetting).Name);
            //}

            //else if (variableType == VariableType.Password)
            //{
            //    if (isGet)
            //        return Encryption.Decrypt(customSetting.Name);
            //    else
            //        return Encryption.Encrypt(customSetting.Name);
            //}

            //else if (variableType == VariableType.Percentage)
            //{
            //    if (isGet)
            //        return (Convert.ToDecimal(customSetting.Name) * 100M).ToString() + "%";
            //    else

            //        customSetting.Name.Replace("%", "");

            //    return Convert.ToDecimal(customSetting.Name) / 100M;
            //}

            //else
            //{
            //    return "";
            //}
            return customSetting.Name.Trim();
        }


    }
}

