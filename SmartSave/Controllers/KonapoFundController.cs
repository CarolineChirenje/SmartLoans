using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        private readonly IClientService _clientservice;
        private readonly ISettingService _settingService;
        public KonapoFundController(IKonapoFundService service, IClientService clientService, ISettingService settingService)
        {
            _service = service;
            _clientservice = clientService;
            _settingService = settingService;

        }
        public ActionResult KonapoFunds(string refNum = null, bool newfundsOnly = false, int id = 0)
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


        public IActionResult AddKonapoFund(int id = 0)
        {
            if (id > 0)
                HttpContext.Session.SetString("ClientID", id.ToString());
            PopulateDropDownList();
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
                return RedirectToAction("KonapoFunds", "Client", new { id = KonapoFund.ClientID });

            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("KonapoFunds", "Client", new { id = KonapoFund.ClientID });
        }
        // GET:
        public async Task<IActionResult> ViewKonapoFund(int id = 0)
        {

            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));
            var fund = await _service.GetKonapoFund(id);
            return View(fund);
        }
        [HttpPost]
        public JsonResult FundSearch(string prefix)
        {
            var funds = _service.GetFunds(prefix);
            return Json(funds);
        }

        [HttpPost]
        public async Task<IActionResult> ViewKonapoFund(KonapoFund KonapoFund)
        {
            if (ModelState.IsValid)
            {
                KonapoFund update = await (_service.FindKonapoFund(KonapoFund.KonapoFundID));
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
        public async Task<IActionResult> ViewKopanoFundCategory(int id)
        {            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));
            var fund = await _service.GetKonapoFundCategory(id);
            return View(fund);
        }
        public async Task<IActionResult> ViewKonapoFundItem(int id)
        {
            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));
            PopulateDropDownList();
            var fund = await _service.FindKonapoFundCTI(id);
            return View(fund);
        }
        public async Task<IActionResult> Calculation(int id)
        {
            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));
            var fund = await _service.GetKonapoFundCalculation(id);
            return View(fund);
        }

        [HttpPost]
        public async Task<IActionResult> ViewKonapoFundItem(KonapoFundCTI KonapoFund)
        {
            Decimal ProjectedCost = UtilityService.GetDecimalAmount(KonapoFund.ProjectedCostAmount);
            Decimal Amount = UtilityService.GetDecimalAmount(KonapoFund.AmountProvided);
            KonapoFund.KonapoAmount = Amount;
            KonapoFund.ProjectedCost = ProjectedCost;
            if (ModelState.IsValid)
            {
                PopulateDropDownList();
                KonapoFundCTI update = await (_service.FindKonapoFundCTI(KonapoFund.KonapoFundCTIID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(KonapoFund)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewKonapoFundItem", new { id=KonapoFund.KonapoFundCTIID });
                }
                return View(KonapoFund);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewKonapoFundItem", new { id = KonapoFund.KonapoFundCTIID });

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

        private void PopulateDropDownList()
        {
            int clientID = 0;
            try
            {
                clientID = Convert.ToInt32(HttpContext.Session.GetString("ClientID"));
            }
            catch (Exception)
            {
                clientID = 0;
            }
            var ClientList = _clientservice.Clients().Select(t => new
            {
                t.ClientID,
                Name = $" {t.ClientFullName} - {t.AccountNumber}",
            }).OrderBy(t => t.Name);
            ViewBag.ClientList = new SelectList(ClientList, "ClientID", "Name", clientID);

            var fundSourceList = _settingService.GetActiveFundSource().Select(t => new
            {
                t.FundSourceID,
                Name = t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.FundSourceList = new SelectList(fundSourceList, "FundSourceID", "Name");

        }
    }
}