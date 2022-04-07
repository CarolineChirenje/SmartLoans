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
    public class LoanTypeController : BaseController<LoanTypeController>
    {
        private readonly ILoanService _service;
        public LoanTypeController(ILoanService service) => _service = service;
        // GET: LoanType
        public async Task<IActionResult> LoanType()
        {
            Permissions permission = Permissions.View_Loan_Type;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.LoanTypes());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(LoanType LoanType)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(LoanType))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create LoanType a LoanType  with the same Name Already Exists";
                    return View(LoanType);
                }
                if (await (_service.Save(LoanType)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(LoanType));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(LoanType));
        }
        // GET:
        public async Task<IActionResult> ViewLoanType(int id) => View(await _service.FindLoanType(id));

       

        [HttpPost]
        public async Task<IActionResult> ViewLoanType(LoanType LoanType)
        {
            if (ModelState.IsValid)
            {
                LoanType update = await (_service.FindLoanType(LoanType.LoanTypeID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(LoanType)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(LoanType));
                }
                return View(LoanType);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(LoanType);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteLoanType(id)) > 0)
                return RedirectToAction(nameof(LoanType));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewLoanType", new { id });
            }

        }
       
      

    }
}
