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
using SmartInterfaces;
using Microsoft.Extensions.Logging;

namespace SmartLoan.Controllers
{
    public class LoanManagerController : BaseController<LoanManagerController>
    {
        private readonly IManageLoanService _service;
        private readonly ISettingService _settingService;
        private readonly IClientService _clientService;
        private readonly IProductService _productService;
        public LoanManagerController(IManageLoanService service, ISettingService settingService, IClientService clientService, IProductService productService)
        {
            _service = service;
            _settingService = settingService;
            _clientService = clientService;
            _productService = productService;
        }

        // GET: Loans
        public async Task<IActionResult> Loans(string loanRef = null, bool newLoansOnly = false, int companyID = 0)
        {
            Permissions permission = Permissions.View_Loan;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.GetLoans(loanRef, newLoansOnly, companyID));
        }

        public IActionResult AddLoan()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddLoan(Loan Loan)
        {
            if (ModelState.IsValid)
            {

                int _result = await _service.Save(Loan);
                if (_result == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Loan));
                }
                else
                {
                    return RedirectToAction("ViewLoan", new { id = _result });
                }
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Loans));
        }
        // GET:
        public async Task<IActionResult> ViewLoan(int id, string Loanname = null)
        {
            if (id == 0 && Loanname == null)
                return RedirectToAction(nameof(Loans));

            Loan Loan = await _service.FindLoan(id);
            HttpContext.Session.SetString("LoanID", Loan.LoanID.ToString());
            GetDropDownLists();
            return View(Loan);
        }


        [HttpPost]
        public async Task<IActionResult> ViewLoan(Loan Loan)
        {

            if (ModelState.IsValid)
            {

                Loan update = await (_service.FindLoan(Loan.LoanID));
                if (update.IsNotNull())
                {
                    if (await (_service.Update(Loan)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Loan));
                }
                return View(Loan);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Loan);
        }
        [HttpPost]
        public async Task<IActionResult> Approve(LoanFinance loanFinance)
        {
           // if (ModelState.IsValid)
            {
                Loan update = await (_service.FindLoan(loanFinance.LoanID));
                if (update.IsNotNull())
                {
                    if (await (_service.Save(loanFinance)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

                }
            }
            return RedirectToAction("ViewLoan", new { id = loanFinance.LoanID });
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Loans));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewLoan", new { id });
            }

        }
        //Beneficiary Details
        public ActionResult Beneficiaries(int id)
        {
            try
            {
                Permissions permission = Permissions.View_Loan_Beneficiary;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                Beneficiaries beneficiary = _service.LoanBeneficiaries(id);
                return View(beneficiary);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddLoanBeneficiary(LoanBeneficiary loanBeneficiary)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(loanBeneficiary)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("Beneficiaries", new { id = loanBeneficiary.LoanID });
        }

        public async Task<IActionResult> ViewLoanBeneficiary(int id, int loandid)
        {
            if (id == 0)
                return RedirectToAction("Beneficiaries", new { id = loandid });

            Beneficiary LoanBeneficiary = await _service.FindLoanBeneficiary(id);
            if (LoanBeneficiary.IsNull())
                return RedirectToAction("Beneficiaries", new { id = loandid });
            HttpContext.Session.SetString("GenderID", LoanBeneficiary.BeneficiaryDetail.GenderID.ToString());
            GetDropDownLists();
            return View(LoanBeneficiary);
        }

        [HttpPost]
        public async Task<IActionResult> ViewLoanBeneficiary(LoanBeneficiary LoanBeneficiary)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                Beneficiary update = await _service.FindLoanBeneficiary(LoanBeneficiary.LoanBeneficiaryID);
                if (update.IsNotNull())
                {
                    if (await (_service.Update(LoanBeneficiary)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

                        HttpContext.Session.SetString("GenderID", LoanBeneficiary.GenderID.ToString());
                        return View(LoanBeneficiary);
                    }
                }
                return RedirectToAction("ViewLoanBeneficiary", new { id = LoanBeneficiary.LoanBeneficiaryID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("Beneficiaries", new { id = LoanBeneficiary.LoanID });
        }
        [HttpGet]
        public async Task<IActionResult> ActionBeneficiary(int beneficiaryID, int loanid)
        {
            if (await (_service.ActionDependent(beneficiaryID, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewLoanBeneficiary", new { id = beneficiaryID });
            }
            return RedirectToAction("Beneficiaries", new { id = loanid });
        }
        /// <summary>
        /// Loan Document
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Documents(int id)
        {
            try
            {
                Permissions permission = Permissions.Loan_View_Document;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                LoanDocs document = _service.LoanDocuments(id);
                return View(document);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddLoanDocument(LoanDocument loanDocument, IFormFile FileBytes)
        {
            if (ModelState.IsValid)
            {
                bool documentUploaded = await _service.DocumentUploaded(loanDocument.LoanID, loanDocument.DocumentTypeID);
                if (documentUploaded)
                {
                    TempData["Error"] = "A  document of the same type has already been uploaded in the system.Please delete the existing document before trying to  re-upload";
                    return RedirectToAction("Documents", new { id = loanDocument.LoanID });
                }

                Custom documentInformation = _settingService.DocumentFormatMatch(FileBytes.ContentType, loanDocument.DocumentTypeID);
                if (!documentInformation.Bool_Value)
                {
                    TempData["Error"] = $"Document Type MisMatch {documentInformation.String_Value} required";
                    return RedirectToAction("Documents", new { id = loanDocument.LoanID });
                }
                if (FileBytes != null)
                {
                    if (FileBytes.Length > 0)
                    //Convert Image to byte and save to database
                    {
                        int requiredSize = UtilityService.MaximumFileSize;
                        int MegaBytes = requiredSize * 1024 * 1024;
                        var fileSize = FileBytes.Length;
                        if (fileSize > MegaBytes)
                        {

                            TempData["Error"] = $"Document Size should not be more than {requiredSize} MB";
                            return RedirectToAction("Documents", new
                            {
                                id = loanDocument.LoanID
                            });
                        }
                        byte[] file = null;
                        using (var fs1 = FileBytes.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            file = ms1.ToArray();
                        }
                        loanDocument.FileName = FileBytes.FileName;
                        loanDocument.FileType = FileBytes.ContentType;
                        loanDocument.FileBytes = file;
                    }
                }
                if (await (_service.Save(loanDocument)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("Documents", new { id = loanDocument.LoanID });
        }
        public async Task<IActionResult> ViewLoanDocument(int id = 0)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction("Documents", new { id = Convert.ToInt32(HttpContext.Session.GetString("LoanID")) });

            return View(await _service.FindDocument(id));
        }
        [HttpPost]
        public async Task<IActionResult> ViewLoanDocument(LoanDocument loanDocument)
        {
            if (ModelState.IsValid)
            {
                LoanDocument update = await _service.FindDocument(loanDocument.LoanDocumentID);
                if (update.IsNotNull())
                {
                    if (await (_service.Update(update)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                }
                return RedirectToAction("ViewLoan", new { id = loanDocument.LoanDocumentID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewLoanDocument", new { id = loanDocument.LoanDocumentID });
        }
        public async Task<IActionResult> ActionDocument(int id)
        {
            if (await (_service.ActionDocument(id, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewLoanDocument", new { id });
            }
            return RedirectToAction("Documents", new { id = Convert.ToInt32(HttpContext.Session.GetString("LoanID")) });
        }
        [HttpGet]
        public async Task<FileResult> DownloadDocument(int id)
        {
            LoanDocument document = await _service.FindDocument(id);
            return File(document.FileBytes, document.FileType, document.FileName);
        }
        /// <summary>
        /// Client Notes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        public ActionResult Notes(int id)
        {

            try
            {
                Permissions permission = Permissions.View_Loan_Note;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                LoanComments comments = _service.LoanNotes(id);
                return View(comments);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddLoanNote(LoanNote loanNote)
        {
            if (ModelState.IsValid)
            {

                if (await (_service.Save(loanNote)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(loanNote);
                }

            }
            return RedirectToAction("Notes", new { id = loanNote.LoanID });
        }
        [HttpPost]
        public async Task<IActionResult> Finalise(int id)
        {
            if (await (_service.FinaliseLoan(id)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
               
            }
            return RedirectToAction("ViewLoan", new { id });
        }
        [HttpPost]
        public async Task<IActionResult> RejectLoan(LoanNote loanNote)
        {
                if (await (_service.RejectLoan(loanNote)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(loanNote);
                }
            return RedirectToAction("ViewLoan", new { id = loanNote.LoanID });
        }
        public async Task<IActionResult> ViewLoanNote(int id)
        {
            if (id == 0)
                return RedirectToAction("Notes", new { id = Convert.ToInt32(HttpContext.Session.GetString("LoanID")) });
            GetDropDownLists();
            return View(await _service.FindNote(id));
        }
        [HttpPost]
        public async Task<IActionResult> ViewLoanNote(LoanNote loanNote)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                LoanNote update = await _service.FindNote(loanNote.LoanNoteID);
                if (update.IsNotNull())
                {
                    if (await (_service.Update(loanNote)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewLoanNote", new { id = loanNote.LoanNoteID });
                }
                return RedirectToAction("Notes", new { id = loanNote.LoanID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewLoanNote", new { id = loanNote.LoanNoteID });
        }
        public async Task<IActionResult> ActionNote(int noteid, int loanid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("Notes", new { id = loanid });
        }
        public async Task<IActionResult> CloseNote(int noteid, int loanid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Close)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("Notes", new { id = loanid });
        }

        [HttpPost]
        public ActionResult GetProductFees(int productID ,int feeID)
        {
            ProductFee productFees = new ProductFee();
            if (productID != 0)
            {
                productFees = _productService.GetProductFee(productID,feeID);
                if (productFees.IsNotNull())
                    return Json(productFees);
                else
                    return Json(null);
            }
            return Json(null);
        }

        [HttpPost]
        public ActionResult GetProductType(int productID)
        {
            int type = 0;
            if (productID != 0)
            {
                type = _productService.GetProductType(productID);
                return Json(type);
            }
            return Json(type);
        }


        private void GetDropDownLists()
        {
            int LoanID = Convert.ToInt32(HttpContext.Session.GetString("LoanID"));

            var productList = _settingService.GetActiveProductList(); if (productList != null)
            {
                productList.Select(t => new
                {
                    t.ProductID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.ProductList = new SelectList(productList, "ProductID", "Name");
            var genderList = _settingService.GenderList(); if (genderList != null)
            {
                genderList.Select(t => new
                {
                    t.GenderID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.GenderList = new SelectList(genderList, "GenderID", "Name");
            var country = _settingService.GetCountryList().Select(t => new
            {
                t.CountryID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CountryList = new SelectList(country, "CountryID", "Name");

            var currency = _settingService.GetCurrencies().Where(c => c.IsActive).Select(t => new
            {
                t.CurrencyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CurrencyList = new SelectList(currency, "CurrencyID", "Name");


            var loanUse = _settingService.GetLoanUses().Select(t => new
            {
                t.LoanUseID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.LoanUseList = new SelectList(loanUse, "LoanUseID", "Name");


            var loansector = _settingService.GetLoanSectors().Select(t => new
            {
                t.LoanSectorID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.LoanSectorList = new SelectList(loansector, "LoanSectorID", "Name");

            var loanstatus = _settingService.GetLoanStatus().Select(t => new
            {
                t.LoanStatusID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.LoanStatusList = new SelectList(loanstatus, "LoanStatusID", "Name");
            var loanTypes = _settingService.GetLoanTypes().Select(t => new
            {
                t.LoanTypeID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.LoanTypeList = new SelectList(loanTypes, "LoanTypeID", "Name");


            var categoryList = _settingService.GetCategories();
            if (categoryList != null)
            {
                categoryList.Select(t => new
                {
                    t.CategoryID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.CategoryList = new SelectList(categoryList, "CategoryID", "Name");

            var subcategoryList = _settingService.GetSubCategories();
            if (subcategoryList != null)
            {
                subcategoryList.Select(t => new
                {
                    t.SubCategoryID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.SubCategoryList = new SelectList(subcategoryList, "SubCategoryID", "Name");


            var categoryItemList = _settingService.GetCategoryItems();
            if (categoryItemList != null)
            {
                categoryItemList.Select(t => new
                {
                    t.CategoryItemID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.CategoryItemList = new SelectList(categoryItemList, "CategoryItemID", "Name");

            int clientID = 0;
            try
            {
                clientID = Convert.ToInt32(HttpContext.Session.GetString("ClientID"));
            }
            catch (Exception)
            {
                clientID = 0;
            }
            var ClientList = _clientService.Clients().Select(t => new
            {
                t.ClientID,
                Name = $" {t.ClientFullName} - {t.AccountNumber}",
            }).OrderBy(t => t.Name);
            ViewBag.ClientList = new SelectList(ClientList, "ClientID", "Name", clientID);

        }


    }
}
