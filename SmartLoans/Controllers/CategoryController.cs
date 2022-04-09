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
using SmartLoan.Models;
using SmartExtensions;

namespace SmartLoan.Controllers
{
    public class CategoryController : BaseController<CategoryController>
    {
        private readonly ILoanService _service;
        public CategoryController(ILoanService service)
        {
            _service = service;

        }

        public async Task<IActionResult> Category()
        {
            Permissions permission = Permissions.View_Category;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Categories());
        }

        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(Category Category)
        {

            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(Category))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Category a Category with the same Title Already Exists";
                    return View(Category);
                }
                int _result = await (_service.Save(Category));
                if (_result == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Category));
                }
                else
                    return RedirectToAction("ViewCategory", new { id = _result });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Category);
        }
        // GET:
        public async Task<IActionResult> ViewCategory(int id = 0)
        {

            if (id == 0)
                return RedirectToAction(nameof(Category));
            HttpContext.Session.SetString("CategoryID", id.ToString());
            PopulateDropDownList();
            var _cat = await _service.FindCategory(id);
            if (_cat.IsNotNull())
                return View(_cat);
            else
                return RedirectToAction(nameof(Category));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCategory(Category Category)
        {
            PopulateDropDownList();
            if (ModelState.IsValid)
            {
                Category update = await (_service.FindCategory(Category.CategoryID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(Category)) == 0)
                    {
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return RedirectToAction(nameof(Category));
                    }
                }
                return View(Category);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Category);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.ActionCategory(id, DatabaseAction.Remove)) == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCategory", new { id });

            }
            return RedirectToAction(nameof(Category));

        }

        /// <summary>
        /// Sub Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddSubCategory(SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(subCategory))
                {
                    TempData["Error"] = "A Sub-Category with the Same Name Already Exists";
                    return RedirectToAction("ViewCategory", new { id = subCategory.CategoryID });

                }
                if (await (_service.Save(subCategory)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

                }
                return RedirectToAction("ViewCategory", new { id = subCategory.CategoryID });
            }
            return RedirectToAction("ViewCategory", new { id = subCategory.CategoryID });
        }
        public async Task<IActionResult> ViewSubCategory(int id)
        {
            HttpContext.Session.SetString("SubCategoryID", id.ToString());
            PopulateDropDownList();
            return View(await _service.FindSubCategory(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewSubCategory(SubCategory subCategory)
        {
            SubCategory subCategory1 = await _service.FindSubCategory(subCategory.SubCategoryID);
            if (ModelState.IsValid)
            {
                if (subCategory1.IsNotNull())
                {
                    if (await (_service.Update(subCategory)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(subCategory1);
                    }
                }
                subCategory1 = await _service.FindSubCategory(subCategory.SubCategoryID);

                return View(subCategory1);
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(subCategory1);
        }
        public async Task<IActionResult> ActionSubCategory(int Categoryid, int SubCategoryID)
        {
            if (await (_service.ActionSubCategory(SubCategoryID, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewSubCategory", new { id = SubCategoryID });
            }
            return RedirectToAction("ViewCategory", new { id = Categoryid });
        }

        /// <summary>
        ///  CategoryItem
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddCategoryItem(CategoryItem categoryItem)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(categoryItem))
                {
                    TempData["Error"] = "A category item with the Same Name Already Exists";
                    return RedirectToAction("ViewSubCategory", new { id = categoryItem.SubCategoryID });

                }
                if (await (_service.Save(categoryItem)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

                return RedirectToAction("ViewSubCategory", new { id = categoryItem.SubCategoryID });
            }
            return RedirectToAction("ViewSubCategory", new { id = categoryItem.SubCategoryID });
        }
        public async Task<IActionResult>ViewCategoryItem(int id)
        {
            HttpContext.Session.SetString("CategoryItemID", id.ToString());
            PopulateDropDownList();
            return View(await _service.FindCategoryItem(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCategoryItem(CategoryItem categoryItem)
        {
            CategoryItem categoryItem1 = await _service.FindCategoryItem(categoryItem.CategoryItemID);
            if (ModelState.IsValid)
            {
                if (categoryItem1.IsNotNull())
                {
                    if (await (_service.Update(categoryItem)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(categoryItem1);
                    }
                }
                categoryItem1 = await _service.FindCategoryItem(categoryItem.CategoryItemID);

                return View(categoryItem1);
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(categoryItem1);
        }
        public async Task<IActionResult> ActionCategoryItem(int CategoryItemID, int SubCategoryID)
        {
            if (await (_service.ActionSubCategory(SubCategoryID, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCategoryItem", new { id = CategoryItemID });
            }
            return RedirectToAction("ViewSubCategory", new { id = SubCategoryID });
        }
        public void PopulateDropDownList()
        {
            int subCategoryID = Convert.ToInt32(HttpContext.Session.GetString("SubCategoryID"));

        }
    }
}