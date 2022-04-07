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
    public class LoanUseController : BaseController<LoanUseController>
    {
        private readonly ILoanService _service;
        public LoanUseController(ILoanService service) => _service = service;
        // GET: LoanUse
        public async Task<IActionResult> LoanUse()
        {
            Permissions permission = Permissions.View_Loan_Use;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.LoanUses());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(LoanUse LoanUse)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(LoanUse))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create LoanUse a LoanUse  with the same Name Already Exists";
                    return View(LoanUse);
                }
                if (await (_service.Save(LoanUse)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(LoanUse));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(LoanUse));
        }
        // GET:
        public async Task<IActionResult> ViewLoanUse(int id) => View(await _service.FindLoanUse(id));

       

        [HttpPost]
        public async Task<IActionResult> ViewLoanUse(LoanUse LoanUse)
        {
            if (ModelState.IsValid)
            {
                LoanUse update = await (_service.FindLoanUse(LoanUse.LoanUseID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(LoanUse)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(LoanUse));
                }
                return View(LoanUse);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(LoanUse);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteLoanUse(id)) > 0)
                return RedirectToAction(nameof(LoanUse));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewLoanUse", new { id });
            }

        }
       
      

    }
}
