using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHelper;
using SmartDomain;
using Microsoft.AspNetCore.Http;
using SmartSave.Models;

namespace SmartSave.Controllers
{
    public class FundController : BaseController<FundController>
    {
        private readonly IKonapoFundService _service;
        public FundController(IKonapoFundService service)
        {
            _service = service;

        }

        public async Task<IActionResult> Fund()
        {
            Permissions permission = Permissions.View_Fund;
            if (!UtilityService.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Funds());
        }

        public IActionResult AddFund()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddFund(Fund Fund)
        {

            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(Fund))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Fund an Fund with the same Title Already Exists";
                    return View(Fund);
                }
                int _result = await (_service.Save(Fund));
                if (_result == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Fund));
                }
                else
                    return RedirectToAction("ViewFund", new { id = _result });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Fund);
        }
        // GET:
        public async Task<IActionResult> ViewFund(int id = 0)
        {

            if (id == 0)
                return RedirectToAction(nameof(Fund));
            HttpContext.Session.SetString("FundID", id.ToString());
            PopulateDropDownList();
            var fund = await _service.FindFund(id);
            if (UtilityService.IsNotNull(fund))
                return View(fund);
            else
                return RedirectToAction(nameof(Fund));
        }


        [HttpPost]
        public async Task<IActionResult> ViewFund(Fund Fund)
        {
            PopulateDropDownList();
            if (ModelState.IsValid)
            {
                Fund update = await (_service.FindFund(Fund.FundID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Fund)) == 0)
                    {
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return RedirectToAction(nameof(Fund));
                    }
                }
                return View(Fund);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Fund);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.ActionFund(id, DatabaseAction.Remove)) == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewFund", new { id });

            }
            return RedirectToAction(nameof(Fund));

        }


        /// <summary>
        /// Fund Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        public async Task<IActionResult> AddFundCategoryItem(int FundCategoryID, int FundItemID)
        {
            int FundID = Convert.ToInt32(HttpContext.Session.GetString("FundID"));

            if (ModelState.IsValid)
            {
                FundCategoryItem fundCategoryItem = new FundCategoryItem { FundItemID = FundItemID, FundCategoryID = FundCategoryID };
                if (await _service.IsDuplicate(fundCategoryItem))
                {
                    TempData["Error"] = "A Category Item with the Same Name Already Exists";
                    return RedirectToAction("ViewFundCategory", new { id = fundCategoryItem.FundCategoryID });
               }
                fundCategoryItem.IsActive = true;
                if (await (_service.Save(fundCategoryItem)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

                }
                return RedirectToAction("ViewFundCategory", new { Categoryid = fundCategoryItem.FundCategoryID, Fundid= FundID });
            }
            return RedirectToAction("ViewFundCategory", new { Categoryid = FundCategoryID, Fundid=FundID });
        }

        //[HttpPost]
        //public async Task<IActionResult> AddFundCategoryItem(int FundCategoryID, int FundItemID)
        //{
    
        //    if (ModelState.IsValid)
        //    {
        //        FundCategoryItem fundCategoryItem = new FundCategoryItem { FundItemID = FundItemID, FundCategoryID = FundCategoryID };
        //        if (await _service.IsDuplicate(fundCategoryItem))
        //        {
        //            TempData["Error"] = "A Category Item with the Same Name Already Exists";
        //            return RedirectToAction("ViewFundCategory", new { id = fundCategoryItem.FundCategoryID });

        //        }
        //        if (await (_service.Save(fundCategoryItem)) == 0)
        //        {
        //            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

        //        }
        //        return RedirectToAction("ViewFundCategory", new { id = fundCategoryItem.FundCategoryID });
        //    }
        //    return RedirectToAction("ViewFundCategory", new { id = FundCategoryID });
        //}
        [HttpPost]
        public async Task<IActionResult> AddFundCategory(FundCategory FundCategory)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(FundCategory))
                {
                    TempData["Error"] = "A Category with the Same Name Already Exists";
                    return RedirectToAction("ViewFund", new { id = FundCategory.FundID });

                }
                if (await (_service.Save(FundCategory)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

                }
                return RedirectToAction("ViewFund", new { id = FundCategory.FundID });
            }
            return RedirectToAction("ViewFund", new { id = FundCategory.FundID });
        }
        public async Task<IActionResult> ViewCategory(int id)
        {            
            HttpContext.Session.SetString("FundCategoryID", id.ToString());
            PopulateDropDownList();
            return View(await _service.FindFundCategory(id));
        }
        public async Task<IActionResult> ViewFundCategory(int Categoryid, int Fundid)
        {
            if (Categoryid == 0)
                return RedirectToAction("ViewFund", new { id = Fundid });
            HttpContext.Session.SetString("FundCategoryID", Categoryid.ToString());
            PopulateDropDownList();
            return View(await _service.FindFundCategory(Categoryid));
        }


        [HttpPost]
        public async Task<IActionResult> ViewFundCategory(FundCategory FundCategory)
        {
            FundCategory _FundCategory = await _service.FindFundCategory(FundCategory.FundCategoryID);
            if (ModelState.IsValid)
            {

                if (UtilityService.IsNotNull(_FundCategory))
                {
                    if (await (_service.Update(FundCategory)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(_FundCategory);
                    }
                }
                _FundCategory = await _service.FindFundCategory(FundCategory.FundCategoryID);

                return View(_FundCategory);
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(_FundCategory);
        }
        public async Task<IActionResult> ActionFundCategory(int Categoryid, int Fundid)
        {
            if (await (_service.ActionFundCategory(Categoryid, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewFundCategory", new { id = Categoryid });
            }
            return RedirectToAction("ViewFund", new { id = Fundid });
        }
        public void PopulateDropDownList()
        {
            int FundCategoryID = Convert.ToInt32(HttpContext.Session.GetString("FundCategoryID"));
            if (FundCategoryID > 0)
            {
                var FundCategories = _service.GetFundItemNotInCategory(FundCategoryID).Result;
                var viewModel = new List<CheckBoxListItem>();
                foreach (var category in FundCategories)
                {
                    viewModel.Add(new CheckBoxListItem
                    {
                        ID = category.FundItemID,
                        Name = category.Name,
                        IsChecked = false
                    });
                }
                ViewBag.FundItemList = viewModel;
            }
        }
    }
}