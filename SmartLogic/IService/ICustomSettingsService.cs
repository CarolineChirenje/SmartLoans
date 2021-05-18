using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomSetting = SmartDomain.CustomSetting;

namespace SmartLogic
{
   public interface ICustomSettingsService
    {
        Task<int> Delete(int id);
        Task<int> Save(CustomSetting customsetting);
        Task<int> Update(CustomSetting customsetting);
        Task<int> ActionCustomSetting(int id, DatabaseAction action);
        Task<CustomSetting> FindCustomSetting(int customSettingID);
       Task<List<CustomSetting>> CustomSettings();
        List<CustomSetting> GetCustomSettings();
        CustomSelectList GetCustomSetting(AppSetting applicationSetting);
        string GetSettingValue(AppSetting applicationSetting);
       
    }
}
