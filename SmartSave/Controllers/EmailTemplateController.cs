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

namespace SmartSave.Controllers
{
    public class EmailTemplateController : BaseController<EmailTemplateController>
    {
        private readonly IEmailTemplateService _service;
        private readonly ISettingService _settingservice;
        public EmailTemplateController(IEmailTemplateService service, ISettingService settingService)
        {
            _service = service;
            _settingservice = settingService;
        }

        public async Task<IActionResult> EmailTemplate()
        {
            Permissions permission = Permissions.View_Email_Template;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.EmailTemplates());
        }

        public IActionResult AddEmailTemplate()
        {
            FillDropDownLists();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmailTemplate(EmailTemplate EmailTemplate)
        {
            FillDropDownLists();
            if (ModelState.IsValid)
            {
                if (await (_service.Save(EmailTemplate)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(EmailTemplate));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(EmailTemplate); 
        }
        // GET:
        public async Task<IActionResult> ViewEmailTemplate(int id = 0)
        {
            if (id == 0 )
                return RedirectToAction(nameof(EmailTemplate));
            FillDropDownLists();
            return View(await _service.FindEmailTemplate(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewEmailTemplate(EmailTemplate EmailTemplate)
        {
            FillDropDownLists();
            if (ModelState.IsValid)
            {
                EmailTemplate update = await (_service.FindEmailTemplate(EmailTemplate.EmailTemplateID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(EmailTemplate)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(EmailTemplate));
                }
                return View(EmailTemplate);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(EmailTemplate);
        }


        
        public async Task<IActionResult> ActionEmailTemplate(int id)
        {
            if (await (_service.ActionEmailTemplate(id, DatabaseAction.Remove)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewEmailTemplate", new { id });
        }



        private void FillDropDownLists()
        {
            var emailType = _service.EmailTypes().Select(t => new
            {
                t.EmailTypeID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.EmailTypeList = new SelectList(emailType, "EmailTypeID", "Name");

            var priorityRanks = _settingservice.GetPriorityRanks().Select(t => new
            {
                t.PriorityRankID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.PriorityList = new SelectList(priorityRanks, "PriorityRankID", "Name");



        }


    }
}