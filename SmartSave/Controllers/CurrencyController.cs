using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartLogic.IService;

namespace SmartSave.Controllers
{
    public class CurrencyController : BaseController<CurrencyController>
    {
        private readonly ICurrencyService _service;
        public CurrencyController(ICurrencyService service) => _service = service;

        public async Task<IActionResult> Currency()
        {
            Permissions permission = Permissions.View_Currency;
            if (!UtilityService.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Currency());
        }

        public IActionResult AddCurrency() => View();
        [HttpPost]
        public async Task<IActionResult> AddCurrency(Currency Currency)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(Currency)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Currency));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Currency); 
        }
        // GET:
        public async Task<IActionResult> ViewCurrency(int id = 0)
        {
            if (id == 0 )
                return RedirectToAction(nameof(Currency));

            return View(await _service.FindCurrency(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCurrency(Currency Currency)
        {

            if (ModelState.IsValid)
            {
                Currency update = await (_service.FindCurrency(Currency.CurrencyID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Currency)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Currency));
                }
                return View(Currency);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Currency);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Currency));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCurrency", new { id });
            }

        }
        public async Task<IActionResult> ChangeCurrencystatus(int id, bool status)
        {
            if (await (_service.ActionCurrency(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCurrency", new { id });
        }


       
        // GET:



    }
}