using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHelper;
using SmartDomain;
using System;
using Microsoft.AspNetCore.Http;
using System.IO;
using SmartDataAccess;
using SmartSave.Models;

namespace SmartSave.Controllers
{
    public class ProductController : BaseController<ProductController>
    {
        private readonly IProductService _service;
        private readonly ISettingService _settingService;

        public ProductController(IProductService service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }

        // GET: Product
        public async Task<IActionResult> Product()
        {
            return View(await _service.Products());
        }

        public IActionResult AddProduct()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product Product)
        {
            Decimal _increasePercentage = UtilityService.GetDecimalAmount(Product.increasePercentage);
            Decimal _deductPercentage = UtilityService.GetDecimalAmount(Product.deductPercentage);
            if (ModelState.IsValid)
            {
                Product.IncreamentPercentage = _increasePercentage;
                Product.DeductionPercentage = _deductPercentage;
                int _result = await _service.Save(Product);
                if (_result == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Product));
                }
                else
                {
                    return RedirectToAction("ViewProduct", new { id = _result });
                }
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Product));
        }
        // GET:
        public async Task<IActionResult> ViewProduct(int id, string Productname = null)
        {
            if (id == 0 && Productname == null)
                return RedirectToAction(nameof(Product));

            Product product = await _service.FindProduct(id);
            HttpContext.Session.SetString("ProductID", product.ProductID.ToString());
            product.ClientCount = _service.ClientsOnProduct(id);
            GetDropDownLists();
            return View(product);
        }


        [HttpPost]
        public async Task<IActionResult> ViewProduct(Product Product)
        {
            Decimal _increasePercentage = UtilityService.GetDecimalAmount(Product.increasePercentage);
            Decimal _deductPercentage = UtilityService.GetDecimalAmount(Product.deductPercentage);
            if (ModelState.IsValid)
            {
                Product.IncreamentPercentage = _increasePercentage;
                Product.DeductionPercentage = _deductPercentage;
                Product update = await (_service.GetProduct(Product.ProductID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Product)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Product));
                }
                return View(Product);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Product);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Product));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewProduct", new { id });
            }

        }



        //Assert


        [HttpPost]
        public async Task<IActionResult> AddProductAssert(string[] selectedAsserts, Product product)
        {
            Product update = await (_service.GetProduct(product.ProductID));
            if (UtilityService.IsNotNull(update))
            {
                if (await (_service.UpdateProductAsserts(product.ProductID, selectedAsserts)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewProduct", new { id = product.ProductID });
                }

            }
            return RedirectToAction("ViewProduct", new { id = product.ProductID });
        }


        // Product Fee

        [HttpPost]
        public async Task<IActionResult> AddProductFee(ProductFee productFee)
        {
            Decimal _amount = UtilityService.GetDecimalAmount(productFee.CostAmount);
            productFee.Amount = _amount;
            if (ModelState.IsValid)
            {
                if (await (_service.Save(productFee)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewProduct", new { id = productFee.ProductID });
        }


        public async Task<IActionResult> ViewProductFee(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewProduct", new { id = Convert.ToInt32(HttpContext.Session.GetString("ProductID")) });

            GetDropDownLists();
            ProductFee productFee = await _service.FindProductFee(id);
            if (UtilityService.IsNotNull(productFee))
                return View(productFee);
            else
                return RedirectToAction("ViewProduct", new { id = Convert.ToInt32(HttpContext.Session.GetString("ProductID")) });

        }

        [HttpPost]
        public async Task<IActionResult> ViewProductFee(ProductFee productFee)
        {


            GetDropDownLists();
            ProductFee update = await _service.FindProductFee(productFee.ProductFeeID);
            if (UtilityService.IsNotNull(update))
            {
                if (await (_service.Update(productFee)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewProduct", new { id = productFee.ProductID });
            }
            return RedirectToAction("ViewProduct", new { id = productFee.ProductID });

        }

        public async Task<IActionResult> ActionProductFee(int productFeeID, int productID)
        {
            if (await (_service.ActionProductFee(productFeeID, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewProduct", new { id = productID });
        }

        private void GetDropDownLists()
        {
            int productID = Convert.ToInt32(HttpContext.Session.GetString("ProductID"));
            var country = _settingService.GetCountryList().Select(t => new
            {
                t.CountryID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CountryList = new SelectList(country, "CountryID", "Name");

            var frequency = _settingService.GetFrequencyList().Select(t => new
            {
                t.FrequencyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.FrequencyList = new SelectList(frequency, "FrequencyID", "Name");


            List<Company> activeCompanies = _service.Companies();
            
            int? defaultCompany = activeCompanies.Where(c => c.IsDefault).FirstOrDefault()?.CompanyID;

            var company = activeCompanies.Select(t => new
            {
                t.CompanyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CompanyList = new SelectList(company, "CompanyID", "Name", defaultCompany.HasValue ? defaultCompany.Value : UtilityService.DefaultCompanyID);


            var allAsserts = _service.Asserts().Result;
            var productAsserts = new HashSet<int>(_service.GetProductAsserts(productID)?.Select(a => a.AssertID));
            var assertModel = new List<CheckBoxListItem>();
            foreach (var assert in allAsserts)
            {
                assertModel.Add(new CheckBoxListItem
                {
                    ID = assert.AssertID,
                    Name = assert.Name,
                    IsChecked = productAsserts.Contains(assert.AssertID)
                });
            }
            ViewBag.AssertList = assertModel;

        }


    }
}
