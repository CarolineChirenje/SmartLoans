using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartDomain;
using SmartHelper;
using SmartLogic;

namespace SmartSave.Controllers
{
    public class CompanyController : BaseController<CompanyController>
    {

        private readonly ICompanyService _service;
        private readonly ISettingService _settingService;

        public CompanyController(ICompanyService service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;

        }

        public async Task<IActionResult> Companies()
        {
            Permissions permission = Permissions.View_Company;
            if (!UtilityService.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Companies());
        }

        public IActionResult AddCompany()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCompany(Company Company, IFormFile CompanyLogo)
        {

            if (ModelState.IsValid)
            {

                if (await _service.IsDuplicate(Company))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Company a Company with the same Name Already Exists";
                    return View(Company);
                }
                // To convert the  uploaded Photo as Byte Array before save to DB    
                if (CompanyLogo != null)
                {
                    if (CompanyLogo.Length > 0)
                    {
                        //Getting FileName
                        //var fileName = Path.GetFileName(CompanyLogo.FileName);
                        //Getting file Extension
                        //var fileExtension = Path.GetExtension(fileName);
                        using var target = new MemoryStream();
                        CompanyLogo.CopyTo(target);
                        Company.CompanyLogo = target.ToArray();
                    }
                }
                if (await (_service.Save(Company)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(Company);
                }
                return RedirectToAction("ViewCompany", new { id = Company.CompanyID });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Company);
        }
        // GET:
        public async Task<IActionResult> ViewCompany(int id = 0)
        {

            if (id == 0)
                return RedirectToAction(nameof(Companies));
            GetDropDownLists();
            return View(await _service.FindCompany(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCompany(Company Company, IFormFile CompanyLogo)
        {

            if (ModelState.IsValid)
            {
                Company company = await (_service.FindCompany(Company.CompanyID));
                if (UtilityService.IsNotNull(company))
                {   // To convert the  uploaded Photo as Byte Array before save to DB    
                    if (CompanyLogo != null)
                    {
                        if (CompanyLogo.Length > 0)
                        {
                            //Getting FileName
                           // var fileName = Path.GetFileName(CompanyLogo.FileName);
                            //Getting file Extension
                            //var fileExtension = Path.GetExtension(fileName);

                            using var target = new MemoryStream();
                            CompanyLogo.CopyTo(target);
                            Company.CompanyLogo = target.ToArray();
                        }
                    }
                    if (await (_service.Update(Company)) == 0)
                    {
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(Company);
                    }
                }
                return RedirectToAction("ViewCompany", new { id=Company.CompanyID });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Company);
        }

        public ActionResult RetrieveImage(int id)
        {
            Company company = _service.FindCompany(id).Result;
            if (UtilityService.IsNull(company))
                return null;
            byte[] logo = company.CompanyLogo;
            if (logo != null)
            {
                return File(logo, "image/png");
            }
            else
            {
                return null;
            }
        }

        public async Task<IActionResult> ActionCompany(int id, bool status)
        {
            Company company = await (_service.FindCompany(id));
            if (UtilityService.IsNotNull(company))
            {
                if (await (_service.ActionCompany(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(company);
                }
            }
            return RedirectToAction("ViewCompany", new { id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            Company company = await (_service.FindCompany(id));
            if (UtilityService.IsNotNull(company))
            {
                if (await (_service.ActionCompany(id, DatabaseAction.Remove)) > 0)
                    return RedirectToAction(nameof(Companies));
                else
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(company);
                }
            }
            return RedirectToAction("ViewCompany", new { id });
        }

        private void GetDropDownLists()
        {
           
            var country = _settingService.GetCountryList().Select(t => new
            {
                t.CountryID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CountryList = new SelectList(country, "CountryID", "Name");

        }


    }
}
