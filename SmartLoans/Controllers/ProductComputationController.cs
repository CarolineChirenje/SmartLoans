using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartExtensions;

namespace SmartLoan.Controllers
{
    public class ProductComputationController : BaseController<ProductComputationController>
    {
        private readonly ILoanService _service;
        public ProductComputationController(ILoanService service) => _service = service;
        // GET: ProductComputation
        public async Task<IActionResult> ProductComputation()
        {
            Permissions permission = Permissions.View_Product_Computation;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.ProductComputations());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductComputation ProductComputation)
        {
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(ProductComputation))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Product Computation a Product Computation  with the same Name Already Exists";
                    return View(ProductComputation);
                }
                if (await (_service.Save(ProductComputation)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(ProductComputation));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(ProductComputation));
        }
        // GET:
        public async Task<IActionResult> ViewProductComputation(int id) => View(await _service.FindProductComputation(id));

       

        [HttpPost]
        public async Task<IActionResult> ViewProductComputation(ProductComputation ProductComputation)
        {
            if (ModelState.IsValid)
            {
                ProductComputation update = await (_service.FindProductComputation(ProductComputation.ProductComputationID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(ProductComputation)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(ProductComputation));
                }
                return View(ProductComputation);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(ProductComputation);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteProductComputation(id)) > 0)
                return RedirectToAction(nameof(ProductComputation));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewProductComputation", new { id });
            }

        }
       
      

    }
}
