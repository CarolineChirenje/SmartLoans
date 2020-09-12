using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartDomain;
using SmartHelper;
using SmartLogic;

namespace SmartSave.Controllers
{
    public class CompanyController : Controller
    {

        private readonly ICompanyService _service;
        public CompanyController(ICompanyService service)
        {
            _service = service;

        }

        public async Task<IActionResult> Companies()
        {
            return View(await _service.Companies());
        }

        public IActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCompany(Company Company)
        {

            if (ModelState.IsValid)
            {
                if (await (_service.Save(Company)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Companies));
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Company);
        }
        // GET:
        public async Task<IActionResult> ViewCompany(int id = 0)
        {

            if (id == 0)
                return RedirectToAction(nameof(Companies));

            return View(await _service.FindCompany(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCompany(Company Company)
        {

            if (ModelState.IsValid)
            {
                Company update = await (_service.FindCompany(Company.CompanyID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Company)) == 0)
                        ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Companies));
                }
                return View(Company);
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Company);
        }


        public async Task<IActionResult> ActionCompany(int id, bool status)
        {
            if (await (_service.ActionCompany(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCompany", new { id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.ActionCompany(id,DatabaseAction.Remove)) >0)
                return RedirectToAction(nameof(Companies));
            else
            {
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCompany", new { id });
            }
        }

    }
}
