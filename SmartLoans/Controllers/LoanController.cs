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
using SmartLoan.Models;
using SmartExtensions;

namespace SmartLoan.Controllers
{
    public class LoanController : BaseController<ProductController>
    {
        private readonly IProductService _service;
        private readonly ISettingService _settingService;

        public LoanController(IProductService service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }
        public IActionResult Dashboard() => View();
        // GET: Product
        public async Task<IActionResult> Product()
        {
            Permissions permission = Permissions.View_Product;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

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
                     if (ModelState.IsValid)
            {
               
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
                        GetDropDownLists();
            return View(product);
        }


        [HttpPost]
        public async Task<IActionResult> ViewProduct(Product Product)
        {
            
            if (ModelState.IsValid)
            {
              
                Product update = await (_service.GetProduct(Product.ProductID));
                if (update.IsNotNull())
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
            if (productFee.IsNotNull())
                return View(productFee);
            else
                return RedirectToAction("ViewProduct", new { id = Convert.ToInt32(HttpContext.Session.GetString("ProductID")) });

        }

        [HttpPost]
        public async Task<IActionResult> ViewProductFee(ProductFee productFee)
        {


            GetDropDownLists();
            ProductFee update = await _service.FindProductFee(productFee.ProductFeeID);
            if (update.IsNotNull())
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

            var currency = _settingService.GetCurrencies().Where(c=>c.IsActive).Select(t => new
            {
                t.CurrencyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CurrencyList = new SelectList(currency, "CurrencyID", "Name");


            var productCompution = _settingService.GetProductComputations().Where(c => c.IsActive).Select(t => new
            {
                t.ProductComputationID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.ProductComputationList= new SelectList(productCompution, "ProductComputationID", "Name");


            List<Company> activeCompanies = _service.Companies();
            
            int? defaultCompany = activeCompanies.Where(c => c.IsDefault).FirstOrDefault()?.CompanyID;

            var company = activeCompanies.Select(t => new
            {
                t.CompanyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CompanyList = new SelectList(company, "CompanyID", "Name", defaultCompany ?? UtilityService.DefaultCompanyID);



        }


    }
}
