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
    public class TransactionTypeController : Controller
    {
        private readonly ITransactionTypeService _service;
        public TransactionTypeController(ITransactionTypeService service) => _service = service;

        public async Task<IActionResult> TransactionType()
        {
            return View(await _service.TransactionType());
        }

        public IActionResult AddTransactionType() => View();
        [HttpPost]
        public async Task<IActionResult> AddTransactionType(TransactionType TransactionType)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(TransactionType)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(TransactionType));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(TransactionType); 
        }
        // GET:
        public async Task<IActionResult> ViewTransactionType(int id = 0)
        {
            if (id == 0 )
                return RedirectToAction(nameof(TransactionType));
            PopulateDropDownList();
            return View(await _service.FindTransactionType(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewTransactionType(TransactionType TransactionType)
        {
           // PopulateDropDownList();
           
                TransactionType update = await (_service.FindTransactionType(TransactionType.TransactionTypeID));
                if (UtilityService.IsNotNull(update))
                {
                TransactionType.TransactionStatus = await _service.FindTransactionStatus(TransactionType.TransactionStatusID);
                if (await (_service.Update(TransactionType)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(TransactionType);
                }
                  
                }
            return RedirectToAction(nameof(TransactionType));


        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(TransactionType));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewTransactionType", new { id });
            }

        }
        public async Task<IActionResult> ChangeTransactionTypestatus(int id, bool status)
        {
            if (await (_service.ActionTransactionType(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewTransactionType", new { id });
        }


        void PopulateDropDownList()
        {
            var transState = _service.TransactionStatus().Result.Select(t => new
            {
              t.TransactionStatusID,
                Name = t.Name,
            });
            ViewBag.TransactionStateList = new SelectList(transState, "TransactionStatusID", "Name");



        }// GET:



    }
}