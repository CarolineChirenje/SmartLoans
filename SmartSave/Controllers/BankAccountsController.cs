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
                if (await _service.IsDuplicate(BankAccount))
                {
                    ViewData[MessageDisplayType.Error.ToString()] = "Failed to Create Bank Account a Bank Account with the same name and Account Number Already Exists";
                    return View(BankAccount);
                }

                if (await (_service.Save(BankAccount)) == 0)
                {
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(BankAccount);
                }
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
                BankAccount bankAccount = await (_service.FindBank(BankAccount.BankAccountID));
                if (UtilityService.IsNotNull(bankAccount))
                {
                    if (await (_service.Update(BankAccount)) == 0)
                        ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                }
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(BankAccount);
        }


        public async Task<IActionResult> Delete(int id)
        {
            BankAccount bankAccount = await (_service.FindBank(id));
            if (UtilityService.IsNotNull(bankAccount))
            {
                if (await (_service.Delete(id)) > 0)
                    return RedirectToAction(nameof(BankAccount));
                else
                {
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(bankAccount);
                }
            }
            return RedirectToAction("ViewBankAccount", new { id });
        }
        public async Task<IActionResult> ChangeBankAccountstatus(int id, bool status)
        {
            BankAccount bankAccount = await (_service.FindBank(id));
            if (UtilityService.IsNotNull(bankAccount))
            {
                if (await (_service.ActionBank(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(bankAccount);
            }
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


            var currency = _settingService.GetCurrencies();
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