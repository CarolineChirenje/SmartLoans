using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartLogic.IService;
using SmartExtensions;

namespace SmartSave.Controllers
{
    public class FeatureFlagController : BaseController<FeatureFlagController>
    {
        private readonly IFeatureFlagService _service;
        public FeatureFlagController(IFeatureFlagService service) => _service = service;
        public IActionResult Dashboard() => View();

        public async Task<IActionResult> FeatureFlag()
        {
            Permissions permission = Permissions.View_Feature_Flag;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.FeatureFlag());
        }

        public IActionResult AddFeatureFlag() => View();
        [HttpPost]
        public async Task<IActionResult> AddFeatureFlag(FeatureFlag FeatureFlag)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(FeatureFlag)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(FeatureFlag));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(FeatureFlag); 
        }
        // GET:
        public async Task<IActionResult> ViewFeatureFlag(int id = 0)
        {
            if (id == 0 )
                return RedirectToAction(nameof(FeatureFlag));

            return View(await _service.FindFeatureFlag(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewFeatureFlag(FeatureFlag FeatureFlag)
        {

            if (ModelState.IsValid)
            {
                FeatureFlag update = await (_service.FindFeatureFlag(FeatureFlag.FeatureFlagID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(FeatureFlag)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(FeatureFlag));
                }
                return View(FeatureFlag);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(FeatureFlag);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(FeatureFlag));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewFeatureFlag", new { id });
            }

        }
        public async Task<IActionResult> ChangeFeatureFlagstatus(int id, bool status)
        {
            if (await (_service.ActionFeatureFlag(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewFeatureFlag", new { id });
        }


       
        // GET:



    }
}