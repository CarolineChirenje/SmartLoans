using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartLogic;


namespace SmartLoan.Controllers
{
    public class DocumentTypeController : BaseController<DocumentTypeController>
    {
        private readonly IDocumentTypeService _service;
        private readonly ISettingService _settingService;
        public DocumentTypeController(IDocumentTypeService service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }

        public async Task<IActionResult> DocumentTypes()
        {
            Permissions permission = Permissions.View_Document_Type;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.DocumentTypes());
        }

        public IActionResult AddDocumentType()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDocumentType(DocumentType DocumentType)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(DocumentType))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Document Type a Document Type  with the same Name Already Exists";
                    return View(DocumentType);
                }
                if (await (_service.Save(DocumentType)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(DocumentTypes));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(DocumentType);
        }
        // GET:
        public async Task<IActionResult> ViewDocumentType(int id = 0)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction(nameof(DocumentTypes));

            return View(await _service.FindDocumentType(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewDocumentType(DocumentType DocumentType)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                DocumentType update = await (_service.FindDocumentType(DocumentType.DocumentTypeID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(DocumentType)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(DocumentTypes));
                }
                return View(DocumentType);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(DocumentType);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(DocumentTypes));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewDocumentType", new { id });
            }

        }
        public async Task<IActionResult> ChangeDocumentTypestatus(int id, bool status)
        {
            if (await (_service.ActionDocumentType(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewDocumentType", new { id });
        }

        private void GetDropDownLists()
        {
            var departments = _settingService.GetDocumentFormats().Select(t => new
            {
                t.DocumentFormatID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.DocumentFormatList = new SelectList(departments, "DocumentFormatID", "Name");

        }

    }
}