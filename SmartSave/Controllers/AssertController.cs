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
using SmartExtensions;

namespace SmartSave.Controllers
{
    public class AssertController : BaseController<AssertController>
    {
        private readonly IProductService _service;
        public AssertController(IProductService service)
        {
            _service = service;

        }

        public async Task<IActionResult> Assert()
        {
            Permissions permission = Permissions.View_Assert;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Asserts());
        }

        public IActionResult AddAssert()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAssert(Assert Assert)
        {

            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(Assert))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Assert an Assert with the same Title Already Exists";
                    return View(Assert);
                }
                int _result = await (_service.Save(Assert));
                if (_result == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Assert));
                }
                else
                    return RedirectToAction("ViewAssert", new { id=_result });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Assert);
        }
        // GET:
        public async Task<IActionResult> ViewAssert(int id = 0)
        {

            if (id == 0)
                return RedirectToAction(nameof(Assert));

            HttpContext.Session.SetString("AssertID", id.ToString());
            PopulateDropDownList();
            return View(await _service.FindAssert(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewAssert(Assert Assert)
        {
            PopulateDropDownList();
            if (ModelState.IsValid)
            {
                Assert update = await (_service.FindAssert(Assert.AssertID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(Assert)) == 0)
                    {
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return RedirectToAction(nameof(Assert));
                    }
                }
                return View(Assert);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Assert);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.ActionAssert(id, DatabaseAction.Remove)) == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewAssert", new { id });

            }
            return RedirectToAction(nameof(Assert));

        }


        /// <summary>
        /// Assert Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddAssertCategory(AssertCategory AssertCategory)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(AssertCategory))
                {
                    TempData["Error"] ="A Category with the Same Name Already Exists";
                    return RedirectToAction("ViewAssert", new { id = AssertCategory.AssertID });

                }
                if (await (_service.Save(AssertCategory)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                  
                }
                return RedirectToAction("ViewAssert", new { id = AssertCategory.AssertID });
            }
            return RedirectToAction("ViewAssert", new { id = AssertCategory.AssertID });
        }

        public async Task<IActionResult> ViewAssertCategory(int Categoryid, int Assertid)
        {
            if (Categoryid == 0)
                return RedirectToAction("ViewAssert", new { id = Assertid });

            return View(await _service.FindAssertCategory(Categoryid));
        }


        [HttpPost]
        public async Task<IActionResult> ViewAssertCategory(AssertCategory AssertCategory)
        {
            AssertCategory _AssertCategory = await _service.FindAssertCategory(AssertCategory.AssertCategoryID);
            if (ModelState.IsValid)
            {

                if (_AssertCategory.IsNotNull())
                {
                    if (await (_service.Update(AssertCategory)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(_AssertCategory);
                    }
                }
                _AssertCategory = await _service.FindAssertCategory(AssertCategory.AssertCategoryID);

                return View(_AssertCategory);
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(_AssertCategory);
        }
        public async Task<IActionResult> ActionAssertCategory(int Categoryid, int Assertid)
        {
            if (await (_service.ActionAssertCategory(Categoryid, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewAssertCategory", new { id = Categoryid });
            }
            return RedirectToAction("ViewAssert", new { id = Assertid });
        }
        public void PopulateDropDownList()
        {
            int AssertID = Convert.ToInt32(HttpContext.Session.GetString("AssertID"));
            var AssertCategories= _service.GetAssertCategories(AssertID);
            var viewModel = new List<CheckBoxListItem>();
            foreach (var category in AssertCategories)
            {
                viewModel.Add(new CheckBoxListItem
                {
                    ID = category.AssertCategoryID,
                    Name = category.Name,
                    IsChecked = false
                });
            }
            ViewBag.CategoryList = viewModel;


        }
    }
}