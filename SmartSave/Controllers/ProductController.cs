using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHelper;
using SmartDomain;

namespace SmartSave.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service) => _service = service;
        // GET: Product
        public async Task<IActionResult> Product()
        {
            return View(await _service.Products());
        }

        public IActionResult AddProduct()
        {
            FillDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product Product)
        {
            FillDropDownLists();
            if (ModelState.IsValid)
            {
                if (await (_service.Save(Product)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Product));
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Product));
        }
        // GET:
        public async Task<IActionResult> ViewProduct(int id = 0, string Productname = null)
        {
            if (id == 0 && Productname == null)
                return RedirectToAction(nameof(Product));
            FillDropDownLists();
            return View(await _service.FindProduct(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewProduct(Product Product)
        {
            FillDropDownLists();
            if (ModelState.IsValid)
            {
                Product update = await (_service.GetProduct(Product.ProductID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Product)) == 0)
                        ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Product));
                }
                return View(Product);
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Product);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Product));
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewProduct", new { id });
            }

        }
        public async Task<IActionResult> ChangeProductstatus(int id, bool status)
        {
            if (await (_service.ActionProduct(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewProduct", new { id });
        }
        


        private void FillDropDownLists()
        {
            var frequency = _service.ProductFrequencies().Select(t => new
            {
                t.ProductFrequencyID,
                t.Name,
            }).OrderBy(t => t.Name);

        ViewBag.FrequencyList = new SelectList(frequency, "ProductFrequencyID", "Name");


            List<Company> activeCompanies = _service.Companies();

            int? defaultCompany = activeCompanies.Where(c => c.IsActive).FirstOrDefault().CompanyID;
             
            var company = activeCompanies.Select(t => new
            {
                t.CompanyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CompanyList = new SelectList(company, "CompanyID", "Name", defaultCompany.HasValue? defaultCompany.Value : UtilityService.DefaultCompanyID);

        }

       
    }
}
