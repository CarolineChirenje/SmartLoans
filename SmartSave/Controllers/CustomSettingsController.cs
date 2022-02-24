using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using SmartDomain;
using SmartHelper;
using CustomSetting = SmartDomain.CustomSetting;
using SmartExtensions;

namespace SmartSave.Controllers
{
    public class CustomSettingsController : BaseController<CustomSettingsController>
    {
        private readonly ICustomSettingsService _service;
        private readonly ISettingService _settingService;
        public CustomSettingsController(ICustomSettingsService service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }
        public IActionResult Dashboard() => View();
        public async Task<IActionResult> CustomSettings()
        {
            List<CustomSetting> customSettings = await _service.CustomSettings();
            return View(customSettings.OrderByDescending(x=>x.Name));
        }

     
        // GET:
        public async Task<IActionResult> ViewCustomSettings(int id = 0)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction(nameof(CustomSettings));

            return View(await _service.FindCustomSetting(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCustomSettings(CustomSetting CustomSettings)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                CustomSetting update = await (_service.FindCustomSetting(CustomSettings.CustomSettingID));
                if (update.IsNotNull())
                {
                    if (CustomSettings.CustomSettingID == (int)AppSetting.Mail_Credential_Password)
                    {
                        string value = CustomSettings.Value;
                        CustomSettings.Value = Encryption.Encrypt(value);
                }
                    if (await (_service.Update(CustomSettings)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(CustomSettings));
                }
                return RedirectToAction("ViewCustomSettings", new { id = CustomSettings.CustomSettingID }); 
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewCustomSettings", new { id = CustomSettings.CustomSettingID });
        }


        public async Task<IActionResult> ActionSettingStatus(int id, bool status)
        {
            if (await (_service.ActionCustomSetting(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCustomSettings", new { id });
        }

        private void GetDropDownLists()
        {          
            var customVariables = _settingService.GetCustomVariableTypes().Select(t => new
            {
                t.CustomVariableTypeID,
                t.Name,
            });

            ViewBag.CustomVariableTypeList = new SelectList(customVariables, "CustomVariableTypeID", "Name");

            var customSetting =_service.CustomSettings().Result.Select(t => new
            {
                t.CustomSettingID,
                t.Name,
            });

            ViewBag.CustomSettingsList = new SelectList(customSetting, "CustomSettingID", "Name");
            
        }
    }
}