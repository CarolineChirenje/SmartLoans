using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartExtensions;

namespace SmartLoan.Controllers
{
    public class FiscalYearController : BaseController<FiscalYearController>
    {
        private readonly ILoanService _service;
        public FiscalYearController(ILoanService service) => _service = service;
        // GET: FiscalYear
        public async Task<IActionResult> FiscalYear()
        {
            Permissions permission = Permissions.View_Fiscal_Year;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.FiscalYears());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(FiscalYear FiscalYear)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(FiscalYear))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create FiscalYear a FiscalYear  with the same Name Already Exists";
                    return View(FiscalYear);
                }
                if (await (_service.Save(FiscalYear)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(FiscalYear));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(FiscalYear));
        }
        // GET:
        public async Task<IActionResult> ViewFiscalYear(int id) => View(await _service.FindFiscalYear(id));

       

        [HttpPost]
        public async Task<IActionResult> ViewFiscalYear(FiscalYear FiscalYear)
        {
            if (ModelState.IsValid)
            {
                FiscalYear update = await (_service.FindFiscalYear(FiscalYear.FiscalYearID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(FiscalYear)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(FiscalYear));
                }
                return View(FiscalYear);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(FiscalYear);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteFiscal(id)) > 0)
                return RedirectToAction(nameof(FiscalYear));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewFiscalYear", new { id });
            }

        }
       
      

    }
}
