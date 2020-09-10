using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Http;
using SmartSave.Models;
using SmartDomain;
using SmartHelper;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartLogic.IService;
using SmartReporting;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel;

namespace SmartSave.Controllers
{
    public class ClientController : Controller
    {
        readonly IUserService _userService;
        readonly IClientService _service;
        readonly IDocumentTypeService _documentTypeService;
        readonly ISettingService _settingService;
        readonly ITransactionService _paymentService;
        readonly IDepartmentService _departmentService;
        readonly IBankAccountservice _bankService;
        public ClientController(IClientService service, IUserService userService, IDocumentTypeService documentTypeService,
        ISettingService settingService, ITransactionService paymentService, 
        IBankAccountservice bankService, IDepartmentService departmentService)
        {
            _service = service;
            _userService = userService;
            _documentTypeService = documentTypeService;
            _settingService = settingService;
            _paymentService = paymentService;
           _bankService = bankService;
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Clients(string accountNum = null, bool newClientsOnly = false)
        {
            List<Client> Clients = await _service.Clients();
            if (String.IsNullOrEmpty(accountNum))
                return View(Clients);
            else if (newClientsOnly)
                return View(await _service.NewClients());
            else
                return View(Clients.Where(m => m.AccountNumber.ToString().Contains(accountNum.Trim())));
        }


        public IActionResult AddClient()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddClient(Client Client)
        {
            GetDropDownLists();
            if (await (_service.Save(Client)) == 0)
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("Clients", new { accountNum = String.Empty, registeredOnly = true });
        }

        public async Task<IActionResult> ViewClient(int id = 0, string accountnNum = null)
        {
            var _tempData = TempData["Error"];
           
            HttpContext.Session.SetString("ClientID", id.ToString());

            if (id == 0 && accountnNum == null)
                return RedirectToAction(nameof(Clients));
            Client Client = await _service.FindClient(id);
            HttpContext.Session.SetString("ClientID", Client.ClientID.ToString());
            GetDropDownLists();
           return View(Client);
        }

        [HttpPost]
        public async Task<IActionResult> ViewClient(Client Client)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                Client update = await _service.FindClient(Client.ClientID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Client)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Clients));
                }
                return View(Client);
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Client);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Clients));
            else
            {
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewClient", new { id = id });
            }
        }


        //Contact
        [HttpPost]
        public async Task<IActionResult> AddClientContact(ClientContact ClientContact)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(ClientContact)) == 0)
                    ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewClient", new { id = ClientContact.ClientID });
        }


        public async Task<IActionResult> ViewContact(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            GetDropDownLists();
            ClientContact ClientContact = await _service.FindContact(id);
            if(UtilityService.IsNotNull(ClientContact))
            return View(ClientContact);
            else
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

        }

        [HttpPost]
        public async Task<IActionResult> ViewContact(ClientContact ClientContact)
        {
          
            
                GetDropDownLists();
                ClientContact update = await _service.FindContact(ClientContact.ClientContactID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(ClientContact)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewContact", new { id = ClientContact.ClientContactID });
                }
                return RedirectToAction("ViewContact", new { id = ClientContact.ClientContactID});
            
         
        }

        public async Task<IActionResult> ActionContact(int contactid, int Clientid)
        {
            if (await (_service.ActionContact(contactid,  DatabaseAction.Remove)) == 0)
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Clientid});
        }

   
        /// <summary>
        /// Client Notes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddClientNote(ClientNote ClientNote)
        {
            if (ModelState.IsValid)
            {

                if (await (_service.Save(ClientNote)) == 0)
                {
                    ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = ClientNote.ClientID });
                }

            }
            return RedirectToAction("ViewClient", new { id = ClientNote.ClientID });
        }

        public async Task<IActionResult> ViewClientNote(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            return View(await _service.FindNote(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewClientNote(ClientNote ClientNote)
        {
            if (ModelState.IsValid)
            {
                ClientNote update = await _service.FindNote(ClientNote.ClientNoteID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(ClientNote)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = ClientNote.ClientID });
                }
                return RedirectToAction("ViewClient", new { id = ClientNote.ClientID });
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClientNote", new { id = ClientNote.ClientNoteID });
        }
        public async Task<IActionResult> ActionNote(int noteid, int Clientid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Remove)) == 0)
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id =Clientid });
        }

        public async Task<IActionResult> CloseNote(int noteid, int Clientid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Close)) == 0)
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Clientid });
        }

        /// <summary>
        /// Client Document
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> AddClientDocument(ClientDocument ClientDocument, IFormFile FileBytes)
        {
            if (ModelState.IsValid)
            {
                //TODO : Check document Type and that which was provided and see if it matches otherwise advise
                Custom documentInformation = _settingService.DocumentFormatMatch(FileBytes.ContentType, ClientDocument.DocumentTypeID);
                if (!documentInformation.Bool_Value)
                {
                    TempData["Error"] = $"Document Type MisMatch {documentInformation.String_Value} required";
                    return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
                }
                if (FileBytes != null)
                {
                    if (FileBytes.Length > 0)
                    //Convert Image to byte and save to database
                    {
                        byte[] file = null;
                        using (var fs1 = FileBytes.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            file = ms1.ToArray();
                        }
                        ClientDocument.FileName = FileBytes.FileName;
                        ClientDocument.FileType = FileBytes.ContentType;
                        ClientDocument.FileBytes = file;
                    }
                }
                if (await (_service.Save(ClientDocument)) == 0)
                    ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
        }

        public async Task<IActionResult> ViewClientDocument(int id = 0)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            return View(await _service.FindDocument(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewClientDocument(ClientDocument ClientDocument)
        {
            if (ModelState.IsValid)
            {
                ClientDocument update = await _service.FindDocument(ClientDocument.ClientDocumentID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(update)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
                }
                return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
        }
        public async Task<IActionResult> ActionDocument(int id)
        {
            if (await (_service.ActionDocument(id, DatabaseAction.Remove)) == 0)
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
        }


        [HttpGet]
        public async Task<FileResult> DownloadDocument(int id)
        {
            ClientDocument document = await _service.FindDocument(id);
            return File(document.FileBytes, document.FileType, document.FileName);
        }

        [HttpGet]
        public ActionResult GenerateStatement(Statement statement)
        {

            if(statement.ClientID==0)
                return RedirectToAction(nameof(Clients));

            statement.Client = _service.FindClient(statement.ClientID).Result;


            StatementPrintOut printOut = new StatementPrintOut();

                using (MemoryStream stream = new MemoryStream())
                {
                    Document document = printOut.Print(statement); ;
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                    pdfRenderer.Document = document;
                    pdfRenderer.RenderDocument();
                    pdfRenderer.PdfDocument.Save(stream, false);
                    return File(stream.ToArray(), "application/pdf", statement.Client.ClientRef + ".pdf");
                }
            
        }
        
        //[HttpGet]
        //public async Task<FileResult> DownloadAssignmentDocument(int id)
        //{
        //    ClientAssignment document = await _service.FindAssignmentDocument(id);
        //    return File(document.FileBytes, document.FileType, document.FileName);
        //}

        /// <summary>
        /// Client Payment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddTransaction(Transaction payment)
        {
            GetDropDownLists();
        if (ModelState.IsValid)
            {
                Client Client = await _service.FindClient(payment.ClientID);
                payment.Client = Client;

                if (await (_paymentService.CreatePayment(payment, TransactionType.Payment)) == 0)
                {
                    ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = payment.ClientID });
                }

            }
            return RedirectToAction("ViewClient", new { id = payment.ClientID });
        }

        public async Task<IActionResult> ViewTransaction(int id = 0)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            return View(await _paymentService.PaymentFile(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewTransaction(Transaction payment, int id)
        {
            if (ModelState.IsValid)
            {
                Transaction paymentsFile = await _paymentService.PaymentFile(payment.TransactionID);
                if (UtilityService.IsNotNull(paymentsFile))
                {
                    if (await (_paymentService.CreatePayment(paymentsFile, (TransactionType)id)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = payment.ClientID });
                }
                return RedirectToAction("ViewClient", new { id = payment.ClientID });
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = payment.ClientID });
        }


        //MedicalDetail
        [HttpPost]
        public async Task<IActionResult> AddClientMedicalDetail(ClientMedicalDetail ClientMedicalDetail)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(ClientMedicalDetail)) == 0)
                    ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewClient", new { id = ClientMedicalDetail.ClientID });
        }


        public async Task<IActionResult> ViewMedicalDetail(int id = 0)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            return View(await _service.FindMedicalDetail(id));
        }

        [HttpPost]
        public async Task<IActionResult> ViewMedicalDetail(ClientMedicalDetail ClientMedicalDetail)
        {
            if (ModelState.IsValid)
            {
                ClientMedicalDetail update = await _service.FindMedicalDetail(ClientMedicalDetail.ClientMedicalID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(ClientMedicalDetail)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewMedicalDetail", new { id = ClientMedicalDetail.ClientMedicalID });
                }
                return RedirectToAction("ViewMedicalDetail", new { id = ClientMedicalDetail.ClientMedicalID });
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = ClientMedicalDetail.ClientID });
        }

        public async Task<IActionResult> ActionMedicalDetail(int medicaldetailID, int Clientid)
        {
            if (await (_service.ActionMedicalDetail(medicaldetailID, DatabaseAction.Remove)) == 0)
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id =Clientid });
        }


        //Guarantor Details
        [HttpPost]
        public async Task<IActionResult> AddClientGuarantor(ClientGuarantor ClientGuarantor)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(ClientGuarantor)) == 0)
                    ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewClient", new { id = ClientGuarantor.ClientID });
        }


        public async Task<IActionResult> ViewClientGuarantor(int id, int Clientid)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id =Clientid });

           ClientGuarantor ClientGuarantor = await _service.FindGuarantor(id);
             if(UtilityService.IsNull(ClientGuarantor))
                return RedirectToAction("ViewClient", new { id = Clientid });

            return View(ClientGuarantor);
        }

        [HttpPost]
        public async Task<IActionResult> ViewClientGuarantor(ClientGuarantor ClientGuarantor)
        {
            if (ModelState.IsValid)
            {
                ClientGuarantor update = await _service.FindGuarantor(ClientGuarantor.ClientGuarantorID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(ClientGuarantor)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClientGuarantor", new { id = ClientGuarantor.ClientGuarantorID });
                }
                return RedirectToAction("ViewClientGuarantor", new { id = ClientGuarantor.ClientGuarantorID });
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = ClientGuarantor.ClientID });
        }

        public async Task<IActionResult> ActionGuarantor(int guarantorid,  int Clientid)
        {
            if (await (_service.ActionGuarantor(guarantorid, DatabaseAction.Remove)) == 0)
            {
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewClient", new { id = Clientid });
            }
            return RedirectToAction("ViewClient", new { id = Clientid });
        }


        private void GetDropDownLists()
        {
            var documentTypes = _documentTypeService.DocumentTypes().Result;
            if (documentTypes != null)
            {
                documentTypes.Select(t => new
                {
                    t.DocumentTypeID,
                    t.Name,
                }).OrderBy(t => t.Name);
            };


            ViewBag.DocumentsList = new SelectList(documentTypes, "DocumentTypeID", "Name");


            var contactTypes = _settingService.GetContactTypes(); if (contactTypes != null)
            {
                contactTypes.Select(t => new
                {
                    t.ContactTypeID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }
            ViewBag.ContactTypes = new SelectList(contactTypes, "ContactTypeID", "Name");

            var relationTypes = _settingService.GetRelationshipTypes(); if (relationTypes != null)
            {
                relationTypes.Select(t => new
                {
                    t.RelationshipTypeID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.RelationTypes = new SelectList(relationTypes, "RelationshipTypeID", "Name");
            var paymentLists = _settingService.GetActiveProductList(); if (paymentLists != null)
            {
                paymentLists.Select(t => new
                {
                    t.ProductID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }
            ViewBag.ProductList = new SelectList(paymentLists, "ProductID", "Name");
            var genderList = _settingService.GenderList(); if (genderList != null)
            {
                genderList.Select(t => new
                {
                    t.GenderID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.GenderList = new SelectList(genderList, "GenderID", "Name");


            
            var bankList = _bankService.Banks().Result.Select(t => new
            {
                t.BankAccountID,
                Name = t.AccountName.ToString(),
            }).OrderBy(t => t.Name);

            ViewBag.BankAccountList = new SelectList(bankList, "BankAccountID", "Name");

            var departments = _departmentService.GetDepartments().Select(t => new
            {
                t.DepartmentID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.DepartmentList = new SelectList(departments, "DepartmentID", "Name");

        }

        // this must return unticked  checkboxs if Department has no Department otherwise it will return ticked and unticked boxes 
        // #ndini ndadaro
        //public List<CheckBoxListItem> GetAvailableListItems(int id)
        //{
        //    var allActivities = _activityService.GetActivities();
        //    var ClientActivities = _service.GetClientActivities(id);
        //    var AvailableListItems = new List<CheckBoxListItem>();
        //    foreach (var activity in allActivities)
        //    {
        //        AvailableListItems.Add(new CheckBoxListItem()
        //        {
        //            ID = activity.ActivityID,
        //            Value = activity.Name,
        //            IsChecked = false
        //        });
        //    }
        //    return AvailableListItems;
        //}
    }
}
