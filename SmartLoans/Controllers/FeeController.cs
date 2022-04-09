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
    public class FeeController : BaseController<FeeController>
    {
        private readonly ILoanService _service;
        public FeeController(ILoanService service) => _service = service;
        // GET: Fee
        public async Task<IActionResult> Fee()
        {
            Permissions permission = Permissions.View_Fee;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Fees());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Fee Fee)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(Fee))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Fee a Fee  with the same Name Already Exists";
                    return View(Fee);
                }
                if (await (_service.Save(Fee)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(Fee));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Fee));
        }
        // GET:
        public async Task<IActionResult> ViewFee(int id) => View(await _service.FindFee(id));

       

        [HttpPost]
        public async Task<IActionResult> ViewFee(Fee Fee)
        {
            if (ModelState.IsValid)
            {
                Fee update = await (_service.FindFee(Fee.FeeID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(Fee)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Fee));
                }
                return View(Fee);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Fee);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteFee(id)) > 0)
                return RedirectToAction(nameof(Fee));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewFee", new { id });
            }

        }
       
      

    }
}
