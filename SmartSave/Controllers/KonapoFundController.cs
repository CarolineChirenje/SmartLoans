using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SmartDomain;
using SmartHelper;
using SmartLogic;


namespace SmartSave.Controllers
{
    public class KonapoFundController : BaseController<KonapoFundController>
    {
        private readonly IKonapoFundService _service;
   
        public KonapoFundController(IKonapoFundService service, ISettingService settingService)
        {
            _service = service;
          
        }
        public ActionResult KonapoFunds(string refNum = null, bool newfundsOnly = false ,int id=0)
        {
            try
            {
                if (UtilityService.UserType == (int)TypeOfUser.Employee)
                    return RedirectToAction("Dashboard", "Home");
                if (id > 0)
                {
                    Permissions permission = Permissions.View_Konapo_Fund;
                    if (!UtilityService.HasPermission(permission))
                        return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });
                    List<KonapoFund> funds = _service.GetClientKonapoFunds(id).Result;
                    return View(funds);
                }
                else
                {
                    List<KonapoFund> funds = _service.GetKonapoFunds(refNum, newfundsOnly).Result;
                    Permissions permission = Permissions.View_Konapo_Fund;
                    if (!UtilityService.HasPermission(permission))
                        return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                    if (UtilityService.IsNotNull(funds) && funds.Count == 1)
                        return RedirectToAction("ViewKonapoFund", new { id = Convert.ToInt32(funds.FirstOrDefault().KonapoFundID) });

                    return View(funds);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }


        }
     

        public IActionResult AddKonapoFund()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddKonapoFund(KonapoFund KonapoFund)
        {
        
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(KonapoFund))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Fund Item a Fund Item  with the same Name Already Exists";
                    return View(KonapoFund);
                }
                if (await (_service.Save(KonapoFund)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(KonapoFunds));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(KonapoFund);
        }
        // GET:
        public async Task<IActionResult> ViewKonapoFund(int id = 0)
        {
          
            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));

            return View(await _service.GetKonapoFund(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewKonapoFund(KonapoFund KonapoFund)
        {
         
            if (ModelState.IsValid)
            {
                KonapoFund update = await (_service.GetKonapoFund(KonapoFund.KonapoFundID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(KonapoFund)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(KonapoFunds));
                }
                return View(KonapoFund);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(KonapoFund);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteKonapoFund(id)) > 0)
                return RedirectToAction(nameof(KonapoFunds));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewKonapoFund", new { id });
            }

        }
      

    }
}