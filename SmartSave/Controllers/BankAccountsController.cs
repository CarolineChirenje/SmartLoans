using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartLogic.IService;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SmartSave.Controllers
{
    public class BankAccountsController : Controller
    {
        private readonly IBankAccountservice _service;
        readonly ISettingService _settingService;
        public BankAccountsController(IBankAccountservice service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }

        public async Task<IActionResult> BankAccounts()
        {
            
            return View(await _service.Banks());
        }

        public IActionResult AddBankAccount()
        {
            GetDropDownLists();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBankAccount(BankAccount BankAccount)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                if (await (_service.Save(BankAccount)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(BankAccounts));
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(BankAccount);
        }
        // GET:
        public async Task<IActionResult> ViewBankAccount(int id = 0)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction(nameof(BankAccount));

            return View(await _service.FindBank(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewBankAccount(BankAccount BankAccount)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                BankAccount update = await (_service.FindBank(BankAccount.BankAccountID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(BankAccount)) == 0)
                        ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(BankAccounts));
                }
                return View(BankAccount);
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(BankAccount);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(BankAccount));
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewBankAccount", new { id });
            }

        }
        public async Task<IActionResult> ChangeBankAccountstatus(int id, bool status)
        {
            if (await (_service.ActionBank(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewBankAccount", new { id });
        }



        private void GetDropDownLists()
        {
            var bankAccountTypes = _settingService.GetBankAccountTypes();
            if (bankAccountTypes != null)
            {
                bankAccountTypes.Select(t => new
                {
                    t.BankAccountTypeID,
                    t.Name,
                }).OrderBy(t => t.Name);
            };
            ViewBag.AccountTypeList = new SelectList(bankAccountTypes, "BankAccountTypeID", "Name");


            var  currency = _settingService.GetCurrencies();
            if (currency != null)
            {
                currency.Select(t => new
                {
                    t.CurrencyID,
                    t.Name,
                }).OrderBy(t => t.Name);
            };
            ViewBag.CurrencyList = new SelectList(currency, "CurrencyID", "Name");
        }

        // GET:



    }
}