using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartLogic.IService;
using Maintanance = SmartDomain.Maintanance;
using SmartExtensions;

namespace SmartSave.Controllers
{
    public class MaintananceController : Controller
    {
        private readonly IMaintananceService _service;
        public MaintananceController(IMaintananceService service) => _service = service;

        public async Task<IActionResult> Maintanance()
        {
            Permissions permission = Permissions.View_Maintanances;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Maintanance());
        }
        public IActionResult AddMaintanance()
        {
            return View();
        }    

        public IActionResult MaintananceMode()
        {
            var maintananceMode = _service.FindActiveMaintanance();
            if (maintananceMode.IsNotNull() && !UserAppData.CanOverrideMaintananceMode)
                return View(maintananceMode);
            else
                return RedirectToAction("Login", "Login");
        }

        
        [HttpPost]
        public async Task<IActionResult> AddMaintanance(Maintanance Maintanance)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(Maintanance) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Maintanance));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Maintanance);
        }
        // GET:
        public async Task<IActionResult> ViewMaintanance(int id = 0)
        {
            if (id == 0)
                return RedirectToAction(nameof(Maintanance));

            return View(await _service.FindMaintanance(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewMaintanance(Maintanance Maintanance)
        {

            if (ModelState.IsValid)
            {
                Maintanance update = await (_service.FindMaintanance(Maintanance.MaintananceID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(Maintanance)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Maintanance));
                }
                return View(Maintanance);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Maintanance);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Maintanance));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewMaintanance", new { id });
            }

        }
        public async Task<IActionResult> ChangeMaintanancestatus(int id, bool status)
        {
            if (await (_service.ActionMaintanance(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewMaintanance", new { id });
        }



        // GET:



    }
}