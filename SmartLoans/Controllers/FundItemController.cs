using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartLogic;


namespace SmartLoan.Controllers
{
    public class FundItemController : BaseController<FundItemController>
    {
        private readonly IKonapoFundService _service;
   
        public FundItemController(IKonapoFundService service)
        {
            _service = service;
          
        }

        public async Task<IActionResult> FundItems()
        {
            Permissions permission = Permissions.View_Fund_Item;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.FundItems());
        }

        public IActionResult AddFundItem()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFundItem(FundItem FundItem)
        {
        
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(FundItem))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Fund Item a Fund Item  with the same Name Already Exists";
                    return View(FundItem);
                }
                if (await (_service.Save(FundItem)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(FundItems));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(FundItem);
        }
        // GET:
        public async Task<IActionResult> ViewFundItem(int id = 0)
        {
          
            if (id == 0)
                return RedirectToAction(nameof(FundItems));

            return View(await _service.FindFundItem(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewFundItem(FundItem FundItem)
        {
         
            if (ModelState.IsValid)
            {
                FundItem update = await (_service.FindFundItem(FundItem.FundItemID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(FundItem)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(FundItems));
                }
                return View(FundItem);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(FundItem);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteFundItem(id)) > 0)
                return RedirectToAction(nameof(FundItems));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewFundItem", new { id });
            }

        }
        public async Task<IActionResult> ChangeFundItemstatus(int id, bool status)
        {
            if (await (_service.ActionFundItem(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewFundItem", new { id });
        }

    }
}