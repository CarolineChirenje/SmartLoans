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

namespace SmartLoan.Controllers
{
    public class SupportController : BaseController<SupportController>
    {
        private readonly ISupportService _service;
        public SupportController(ISupportService service) => _service = service;

        public async Task<IActionResult> Support()
        {
            Permissions permission = Permissions.View_Technical_Support_Settings;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Support());
        }

      
        // GET:
        public async Task<IActionResult> ViewSupport(int id = 0)
        {
            if (id == 0 )
                return RedirectToAction(nameof(Support));

            return View(await _service.FindSupport(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewSupport(TechnicalSupport Support)
        {

            if (ModelState.IsValid)
            {
                TechnicalSupport update = await (_service.FindSupport(Support.TechnicalSupportID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(Support)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Support));
                }
                return View(Support);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Support);
        }


      


    }
}