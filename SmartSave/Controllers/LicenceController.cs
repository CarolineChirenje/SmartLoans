using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartLogic.IService;
using Licence = SmartDomain.Licence;

namespace SmartSave.Controllers
{
    public class LicenceController : Controller
    {
        private readonly ILicenceService _service;
        public LicenceController(ILicenceService service) => _service = service;

        public async Task<IActionResult> Licence()
        {
            return View(await _service.Licence());
        }
        public IActionResult AddLicence()
        {
            return View();
        }    

        public IActionResult LicenceMode()
        {
            var licenceMode = _service.FindActiveLicence();
            if (UtilityService.IsNotNull(licenceMode) && !UtilityService.CanOverrideMaintananceMode)
                return View(licenceMode);
            else
                return RedirectToAction("Login", "Login");
        }

        
        [HttpPost]
        public async Task<IActionResult> AddLicence(Licence Licence)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(Licence) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Licence));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Licence);
        }
        // GET:
        public async Task<IActionResult> ViewLicence(int id = 0)
        {
            if (id == 0)
                return RedirectToAction(nameof(Licence));

            return View(await _service.FindLicence(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewLicence(Licence Licence)
        {

            if (ModelState.IsValid)
            {
                Licence update = await (_service.FindLicence(Licence.LicenceID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Licence)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Licence));
                }
                return View(Licence);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Licence);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Licence));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewLicence", new { id });
            }

        }
        public async Task<IActionResult> ChangeLicencestatus(int id, bool status)
        {
            if (await (_service.ActionLicence(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewLicence", new { id });
        }



        // GET:



    }
}