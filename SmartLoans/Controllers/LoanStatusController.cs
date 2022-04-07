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
    public class LoanStatusController : BaseController<LoanStatusController>
    {
        private readonly ILoanService _service;
        public LoanStatusController(ILoanService service) => _service = service;
        // GET: LoanStatus
        public async Task<IActionResult> LoanStatus()
        {
            Permissions permission = Permissions.View_Loan_Status;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.LoanStatuses());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(LoanStatus LoanStatus)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(LoanStatus))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create LoanStatus a LoanStatus  with the same Name Already Exists";
                    return View(LoanStatus);
                }
                if (await (_service.Save(LoanStatus)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(LoanStatus));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(LoanStatus));
        }
        // GET:
        public async Task<IActionResult> ViewLoanStatus(int id) => View(await _service.FindLoanStatus(id));

       

        [HttpPost]
        public async Task<IActionResult> ViewLoanStatus(LoanStatus LoanStatus)
        {
            if (ModelState.IsValid)
            {
                LoanStatus update = await (_service.FindLoanStatus(LoanStatus.LoanStatusID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(LoanStatus)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(LoanStatus));
                }
                return View(LoanStatus);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(LoanStatus);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteLoanStatus(id)) > 0)
                return RedirectToAction(nameof(LoanStatus));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewLoanStatus", new { id });
            }

        }
       
      

    }
}
