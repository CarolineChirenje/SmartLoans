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
    public class CountryController : BaseController<CountryController>
    {
        private readonly ICountryService _service;
        public CountryController(ICountryService service) => _service = service;

        public async Task<IActionResult> Country()
        {
            Permissions permission = Permissions.View_Country;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Country());
        }

        public IActionResult AddCountry() => View();
        [HttpPost]
        public async Task<IActionResult> AddCountry(Country Country)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(Country)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Country));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Country); 
        }
        // GET:
        public async Task<IActionResult> ViewCountry(int id = 0)
        {
            if (id == 0 )
                return RedirectToAction(nameof(Country));

            return View(await _service.FindCountry(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCountry(Country Country)
        {

            if (ModelState.IsValid)
            {
                Country update = await (_service.FindCountry(Country.CountryID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(Country)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Country));
                }
                return View(Country);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Country);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Country));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCountry", new { id });
            }

        }
        public async Task<IActionResult> ChangeCountrystatus(int id, bool status)
        {
            if (await (_service.ActionCountry(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCountry", new { id });
        }


       
        // GET:



    }
}