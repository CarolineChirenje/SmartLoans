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
using SmartExtensions;

namespace SmartLoan.Controllers
{
    public class BankAccountsController : BaseController<BankAccountsController>
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
            Permissions permission = Permissions.View_Bank_Account;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

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
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Bank Account a Bank Account with the same name and Account Number Already Exists";
                    return View(BankAccount);
                }

                int result= await _service.Save(BankAccount);
                if ( result == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(BankAccount);
                }
                else
                {
                    return RedirectToAction("ViewBankAccount", new { id=result });
                }
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
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
                if (bankAccount.IsNotNull())
                {
                    if (await (_service.Update(BankAccount)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                else
                        return RedirectToAction("ViewBankAccount", new { id = BankAccount.BankAccountID });

                }
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewBankAccount", new { id = BankAccount.BankAccountID });
        }


        public async Task<IActionResult> Delete(int id)
        {
            BankAccount bankAccount = await (_service.FindBank(id));
            if (bankAccount.IsNotNull())
            {
                if (await (_service.Delete(id)) > 0)
                    return RedirectToAction(nameof(BankAccounts));
                else
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(bankAccount);
                }
            }
            return RedirectToAction("ViewBankAccount", new { id });
        }
        public async Task<IActionResult> ChangeBankAccountstatus(int id, bool status)
        {
            BankAccount bankAccount = await (_service.FindBank(id));
            if (bankAccount.IsNotNull())
            {
                if (await (_service.ActionBank(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
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