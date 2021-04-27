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
using MigraDocCore.Rendering;
using MigraDocCore.DocumentObjectModel;
using System.Text;
using PdfSharpCore.Pdf.Security;
using Microsoft.Extensions.Logging;
using SmartLog;

namespace SmartSave.Controllers
{
    public class ClientController : BaseController<ClientController>
    {
        readonly IUserService _userService;
        readonly IClientService _service;
        readonly IDocumentTypeService _documentTypeService;
        readonly ISettingService _settingService;
        readonly ITransactionService _paymentService;
        readonly IDepartmentService _departmentService;
        readonly IBankAccountservice _bankService;
        readonly IMailService _mailService;
        readonly IFeatureFlagService _featureFlagService;
        private readonly IEmailTemplateService _emailTemplateService;

        public ClientController(IClientService service, IUserService userService, IDocumentTypeService documentTypeService,
        ISettingService settingService, ITransactionService paymentService,
        IBankAccountservice bankService, IDepartmentService departmentService, IMailService mailservice,
        IFeatureFlagService featureFlagService, IEmailTemplateService emailTemplateService)
        {
            _service = service;
            _userService = userService;
            _documentTypeService = documentTypeService;
            _settingService = settingService;
            _paymentService = paymentService;
            _bankService = bankService;
            _departmentService = departmentService;
            _mailService = mailservice;
            _featureFlagService = featureFlagService;
            _emailTemplateService = emailTemplateService;
        }

        public async Task<IActionResult> Clients(string accountNum = null, bool newClientsOnly = false)
        {
            try
            {
                if (UtilityService.UserType == (int)TypeOfUser.Employee)
                    return RedirectToAction("Dashboard", "Home");

                List<Client> Clients = await _service.Clients();
                if (String.IsNullOrEmpty(accountNum))
                    return View(Clients);
                else if (newClientsOnly)
                    return View(await _service.NewClients());
                else
                    return View(Clients.Where(m => m.AccountNumber.ToString().Contains(accountNum.Trim())));

            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }


        }
        public IActionResult MyAccount()
        {
            if (UtilityService.UserType == (int)TypeOfUser.Employee)
            {
                User user = _userService.FindUser(0, UtilityService.CurrentUserName).Result;
                if (UtilityService.IsNotNull(user))
                {
                    Client client = _service.ClientDetails(user.EmailAddress, user.IDNumber).Result;
                    if (UtilityService.IsNotNull(client))
                    {
                        return RedirectToAction("ViewClient", "Client", new { id = client.ClientID });
                    }
                    else
                        return RedirectToAction("Dashboard", "Home");
                }
                else
                    return RedirectToAction("Dashboard", "Home");
            }
            return RedirectToAction("Dashboard", "Home");
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
            decimal _salary = UtilityService.GetDecimalAmount(Client.SalaryAmount);
            Client.Salary = _salary;
            int _result = await (_service.Save(Client));
            if (_result == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(Client);
            }

            return RedirectToAction("ViewClient", new { id = _result });
        }

        public async Task<IActionResult> ViewClient(int id = 0, string accountnNum = null)
        {
            var _tempData = TempData["Error"];

            HttpContext.Session.SetString("ClientID", id.ToString());

            if (id == 0 && accountnNum == null)
                return RedirectToAction(nameof(Clients));
            Client Client = await _service.FindClient(id);
            if (UtilityService.IsNotNull(Client))
            {
                Client.AttendanceRegister = await _service.AttendanceRegisters(id);
                HttpContext.Session.SetString("ClientID", Client.ClientID.ToString());

                GetDropDownLists();
                return View(Client);
            }
            else
                return RedirectToAction(nameof(Clients));
        }

        [HttpPost]
        public async Task<IActionResult> ViewClient(Client Client)
        {
            GetDropDownLists();
            decimal _salary = UtilityService.GetDecimalAmount(Client.SalaryAmount);
            Client.Salary = _salary;
            if (ModelState.IsValid)
            {
                Client update = await _service.FindClient(Client.ClientID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Client)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(Client);
                    }
                }

                return RedirectToAction("ViewClient", new { id = Client.ClientID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Client);
        }




        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Clients));
            else
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
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
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewClient", new { id = ClientContact.ClientID });
        }


        public async Task<IActionResult> ViewContact(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            GetDropDownLists();
            ClientContact ClientContact = await _service.FindContact(id);
            if (UtilityService.IsNotNull(ClientContact))
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
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewContact", new { id = ClientContact.ClientContactID });
            }
            return RedirectToAction("ViewContact", new { id = ClientContact.ClientContactID });


        }

        public async Task<IActionResult> ActionContact(int contactid, int Clientid)
        {
            if (await (_service.ActionContact(contactid, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Clientid });
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
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(ClientNote);
                }

            }
            return RedirectToAction("ViewClient", new { id = ClientNote.ClientID });
        }

        public async Task<IActionResult> ViewClientNote(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            GetDropDownLists();
            return View(await _service.FindNote(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewClientNote(ClientNote ClientNote)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                ClientNote update = await _service.FindNote(ClientNote.ClientNoteID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(ClientNote)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = ClientNote.ClientID });
                }
                return RedirectToAction("ViewClient", new { id = ClientNote.ClientID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClientNote", new { id = ClientNote.ClientNoteID });
        }
        public async Task<IActionResult> ActionNote(int noteid, int Clientid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Clientid });
        }

        public async Task<IActionResult> CloseNote(int noteid, int Clientid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Close)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

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
                        int requiredSize = UtilityService.MaximumFileSize;
                        int MegaBytes = requiredSize * 1024 * 1024;
                        var fileSize = FileBytes.Length;
                        if (fileSize > MegaBytes)
                        {

                            TempData["Error"] = $"Document Size should not be more than {requiredSize} MB";
                            return RedirectToAction("ViewClient", new
                            {
                                id = ClientDocument.ClientID
                            });
                        }
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
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

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
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
                }
                return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = ClientDocument.ClientID });
        }
        public async Task<IActionResult> ActionDocument(int id)
        {
            if (await (_service.ActionDocument(id, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
        }


        [HttpGet]
        public async Task<FileResult> DownloadDocument(int id)
        {
            ClientDocument document = await _service.FindDocument(id);
            return File(document.FileBytes, document.FileType, document.FileName);
        }

        [HttpGet]
        public ActionResult GenerateStatement(Statement statement, string GenerateStatement, string EmailStatement)
        {
            if (statement.ClientID == 0)
                return RedirectToAction(nameof(Clients));
            statement.Client = _service.FindClient(statement.ClientID).Result;
            statement.Product = _settingService.FindProduct(statement.ProductID);
            string filename = statement.Client.AccountNumber;
            TransactionalStatement printOut = new TransactionalStatement();
            if (!string.IsNullOrEmpty(GenerateStatement))
            {

                using (MemoryStream stream = new MemoryStream())
                {
                    Document document = printOut.Print(statement); ;
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                    pdfRenderer.Document = document;
                    pdfRenderer.RenderDocument();
                    pdfRenderer.PdfDocument.Save(stream, false);
                    return File(stream.ToArray(), "application/pdf", filename + ".pdf");
                }

            }
            else
            {

                EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplate((int)EmailTypeList.Client_Statement).Result;
                byte[] pdfFile = GeneratePDFStatement(statement);
                List<AttachmentFromMemory> attachments = new List<AttachmentFromMemory>();
                AttachmentFromMemory attachment = new AttachmentFromMemory
                {
                    FileExtension = "pdf",
                    MemoryStream = new MemoryStream(pdfFile),
                    Name = UtilityService.MaskAccountNumber(filename)
                };

                attachments.Add(attachment);

                Email email = new Email();
                email.To = statement.Client.EmailAddress;
                email.AttachmentFromMemory = attachments;
                if (UtilityService.IsNotNull(emailTemplate))
                {
                    email.Body = emailTemplate.Body;
                    email.Subject = emailTemplate.Subject;
                }
                if (_mailService.SendMail(email))
                    TempData[MessageDisplayType.Success.ToString()] = $"Email Successfully sent to {statement.Client.EmailAddress}";
                else
                    TempData[MessageDisplayType.Error.ToString()] = $"Failed to send email to {statement.Client.EmailAddress}";
                return RedirectToAction("ViewClient", new { id = statement.ClientID });
            }
        }

        [HttpGet]
      
        public ActionResult GenerateOutStandingStatement(OutstandingStatement statement, string GenerateOutStandingStatement)
        {
            if (statement.ClientID == 0)
                return RedirectToAction(nameof(Clients));
                     
            statement.Client = _service.FindClient(statement.ClientID).Result;
            string filename = statement.Client.AccountNumber;
            OutstandingPayments printOut = new OutstandingPayments();
            if (!string.IsNullOrEmpty(GenerateOutStandingStatement))
            {

                using (MemoryStream stream = new MemoryStream())
                {
                    Document document = printOut.Print(statement); 
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                    pdfRenderer.Document = document;
                    pdfRenderer.RenderDocument();
                    pdfRenderer.PdfDocument.Save(stream, false);
                    return File(stream.ToArray(), "application/pdf", filename + ".pdf");
                }

            }
            else
            {

                EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplate((int)EmailTypeList.Client_Statement).Result;
                byte[] pdfFile = GeneratePDFOutstandingPaymentsStatement(statement);
                List<AttachmentFromMemory> attachments = new List<AttachmentFromMemory>();
                AttachmentFromMemory attachment = new AttachmentFromMemory
                {
                    FileExtension = "pdf",
                    MemoryStream = new MemoryStream(pdfFile),
                    Name = UtilityService.MaskAccountNumber(filename)
                };

                attachments.Add(attachment);

                Email email = new Email();
                email.To = statement.Client.EmailAddress;
                email.AttachmentFromMemory = attachments;
                if (UtilityService.IsNotNull(emailTemplate))
                {
                    email.Body = emailTemplate.Body;
                    email.Subject = emailTemplate.Subject;
                }
                if (_mailService.SendMail(email))
                    TempData[MessageDisplayType.Success.ToString()] = $"Email Successfully sent to {statement.Client.EmailAddress}";
                else
                    TempData[MessageDisplayType.Error.ToString()] = $"Failed to send email to {statement.Client.EmailAddress}";
                return RedirectToAction("ViewClient", new { id = statement.ClientID });
            }
        }


        private byte[] GeneratePDFStatement(Statement statement)
        {
            byte[] pdffile = null;
            TransactionalStatement printOut = new TransactionalStatement();

            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    Document document = printOut.Print(statement);
                    // Create a renderer for the MigraDoc document.
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                    // Associate the MigraDoc document with a renderer
                    pdfRenderer.Document = document;

                    // Layout and render document to PDF
                    pdfRenderer.RenderDocument();
                    if (UtilityService.StatementPasswordProtect)
                    {
                        PdfSecuritySettings securitySettings = pdfRenderer.PdfDocument.SecuritySettings;

                        securitySettings.UserPassword = statement.Client.IDNumber.Trim();
                        securitySettings.OwnerPassword = UtilityService.StatementPasswordForAdmin.Trim();

                        // Restrict some rights.
                        securitySettings.PermitAccessibilityExtractContent = false;
                        securitySettings.PermitAnnotations = false;
                        securitySettings.PermitAssembleDocument = false;
                        securitySettings.PermitExtractContent = false;
                        securitySettings.PermitFormsFill = true;
                        securitySettings.PermitFullQualityPrint = false;
                        securitySettings.PermitModifyDocument = true;
                        securitySettings.PermitPrint = false;
                    }

                    pdfRenderer.PdfDocument.Save(stream, false);
                    pdffile = stream.ToArray();
                }
                catch (Exception ex)
                {

                    CustomLog.Log(LogSource.GUI, ex);
                }
               
            }
            return pdffile;
        }
        private byte[] GeneratePDFOutstandingPaymentsStatement(OutstandingStatement statement)
        {
            byte[] pdffile = null;
            OutstandingPayments printOut = new OutstandingPayments();

            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    Document document = printOut.Print(statement);
                    // Create a renderer for the MigraDoc document.
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                    // Associate the MigraDoc document with a renderer
                    pdfRenderer.Document = document;

                    // Layout and render document to PDF
                    pdfRenderer.RenderDocument();
                    if (UtilityService.StatementPasswordProtect)
                    {
                        PdfSecuritySettings securitySettings = pdfRenderer.PdfDocument.SecuritySettings;

                        securitySettings.UserPassword = statement.Client.IDNumber.Trim();
                        securitySettings.OwnerPassword = UtilityService.StatementPasswordForAdmin.Trim();

                        // Restrict some rights.
                        securitySettings.PermitAccessibilityExtractContent = false;
                        securitySettings.PermitAnnotations = false;
                        securitySettings.PermitAssembleDocument = false;
                        securitySettings.PermitExtractContent = false;
                        securitySettings.PermitFormsFill = true;
                        securitySettings.PermitFullQualityPrint = false;
                        securitySettings.PermitModifyDocument = true;
                        securitySettings.PermitPrint = false;
                    }

                    pdfRenderer.PdfDocument.Save(stream, false);
                    pdffile = stream.ToArray();
                }
                catch (Exception ex)
                {

                    CustomLog.Log(LogSource.GUI, ex);
                }

            }
        
            return pdffile;
        }


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

                if (await (_paymentService.CreatePayment(payment, (TransactionTypeList)payment.TransactionTypeID)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = payment.ClientID });
                }

            }
            return RedirectToAction("ViewClient", new { id = payment.ClientID });
        }

        // GET:
        public async Task<IActionResult> ViewClientTransaction(int id)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction(nameof(Clients));
            Transaction transaction = await _paymentService.PaymentFile(id, null);
            return View(transaction);
        }

        [HttpGet]
        public async Task<IActionResult> ActionTransaction(int id, int transactionTypeID, int clientid)
        {
            Transaction paymentsFile = await (_paymentService.PaymentFile(id));
            if (UtilityService.IsNotNull(paymentsFile))
            {
                if (await (_paymentService.ReversePayment(paymentsFile, (TransactionTypeList)transactionTypeID)) == 0)
                {

                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

                }

            }
            return RedirectToAction("ViewClient", "Client", new { id = clientid });

        }

        public async Task<IActionResult> ViewTransaction(int id = 0)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            GetDropDownLists();
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
                    if (await (_paymentService.CreatePayment(paymentsFile, (TransactionTypeList)id)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = payment.ClientID });
                }
                return RedirectToAction("ViewClient", new { id = payment.ClientID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = payment.ClientID });
        }


        //MedicalDetail
        [HttpPost]
        public async Task<IActionResult> AddClientMedicalDetail(ClientMedicalDetail ClientMedicalDetail)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(ClientMedicalDetail)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewClient", new { id = ClientMedicalDetail.ClientID });
        }


        public async Task<IActionResult> ViewMedicalDetail(int id = 0)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            GetDropDownLists();
            return View(await _service.FindMedicalDetail(id));
        }

        [HttpPost]
        public async Task<IActionResult> ViewMedicalDetail(ClientMedicalDetail ClientMedicalDetail)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                ClientMedicalDetail update = await _service.FindMedicalDetail(ClientMedicalDetail.ClientMedicalID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(ClientMedicalDetail)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewMedicalDetail", new { id = ClientMedicalDetail.ClientMedicalID });
                }
                return RedirectToAction("ViewMedicalDetail", new { id = ClientMedicalDetail.ClientMedicalID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = ClientMedicalDetail.ClientID });
        }

        public async Task<IActionResult> ActionMedicalDetail(int medicaldetailID, int Clientid)
        {
            if (await (_service.ActionMedicalDetail(medicaldetailID, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Clientid });
        }


        //Dependent Details
        [HttpPost]
        public async Task<IActionResult> AddClientDependent(ClientDependent ClientDependent)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(ClientDependent)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewClient", new { id = ClientDependent.ClientID });
        }


        public async Task<IActionResult> ViewClientDependent(int id, int Clientid)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Clientid });

            ClientDependent ClientDependent = await _service.FindDependent(id);
            if (UtilityService.IsNull(ClientDependent))
                return RedirectToAction("ViewClient", new { id = Clientid });
            HttpContext.Session.SetString("GenderID", ClientDependent.GenderID.ToString());
            GetDropDownLists();
            return View(ClientDependent);
        }

        [HttpPost]
        public async Task<IActionResult> ViewClientDependent(ClientDependent ClientDependent)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                ClientDependent update = await _service.FindDependent(ClientDependent.ClientDependentID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(ClientDependent)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

                        HttpContext.Session.SetString("GenderID", ClientDependent.GenderID.ToString());
                        return View(ClientDependent);
                    }
                }
                return RedirectToAction("ViewClientDependent", new { id = ClientDependent.ClientDependentID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClient", new { id = ClientDependent.ClientID });
        }
        [HttpPost]
        public async Task<IActionResult> ActionDependent(int Dependentid, int Clientid)
        {
            if (await (_service.ActionDependent(Dependentid, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewClient", new { id = Clientid });
            }
            return RedirectToAction("ViewClient", new { id = Clientid });
        }
        /// <summary>
        /// Client Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddClientProduct(ClientProduct ClientProduct)
        {
            if (ModelState.IsValid)
            {
                if (!String.IsNullOrEmpty(ClientProduct.DeductionAmount))
                {
                    decimal _deductionAmount = UtilityService.GetDecimalAmount(ClientProduct.DeductionAmount);
                    if (_deductionAmount > 0)
                        ClientProduct.DeductionPercentage = _deductionAmount;
                }
                if (!String.IsNullOrEmpty(ClientProduct.IncreamentAmount))
                {
                    decimal _increamentAmount = UtilityService.GetDecimalAmount(ClientProduct.IncreamentAmount);
                    if (_increamentAmount > 0)
                        ClientProduct.IncreamentPercentage = _increamentAmount;
                }
                if (await (_service.Save(ClientProduct)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = ClientProduct.ClientID });
                }

            }
            return RedirectToAction("ViewClient", new { id = ClientProduct.ClientID });
        }

        public async Task<IActionResult> ViewClientProduct(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            GetDropDownLists();
            return View(await _service.FindProduct(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewClientProduct(ClientProduct clientProduct)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {

                ClientProduct update = await _service.FindProduct(clientProduct.ClientProductID);
                if (UtilityService.IsNotNull(update))
                {
                    if (!String.IsNullOrEmpty(clientProduct.DeductionAmount))
                    {
                        decimal _deductionAmount = UtilityService.GetDecimalAmount(clientProduct.DeductionAmount);
                        if (_deductionAmount > 0)
                            clientProduct.DeductionPercentage = _deductionAmount;
                    }
                    if (!String.IsNullOrEmpty(clientProduct.IncreamentAmount))
                    {
                        decimal _increamentAmount = UtilityService.GetDecimalAmount(clientProduct.IncreamentAmount);
                        if (_increamentAmount > 0)
                            clientProduct.IncreamentPercentage = _increamentAmount;
                    }
                    if (await (_service.Update(clientProduct)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return RedirectToAction("ViewClient", new { id = clientProduct.ClientID });
                    }
                }
                return RedirectToAction("ViewClientProduct", new { id = clientProduct.ClientProductID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClientProduct", new { id = clientProduct.ClientProductID });
        }
        public async Task<IActionResult> ActionClientProduct(int productid, int Clientid)
        {
            if (await (_service.ActionProduct(productid, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Clientid });
        }


        /// <summary>
        /// Client Course
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddClientCourse(ClientCourse ClientCourse)
        {
            if (ModelState.IsValid)
            {

                if (await (_service.Save(ClientCourse)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = ClientCourse.ClientID });
                }

            }
            return RedirectToAction("ViewClient", new { id = ClientCourse.ClientID });
        }

        public async Task<IActionResult> ViewClientCourse(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            ClientCourse clientCourse = await _service.FindCourse(id);
            if (UtilityService.IsNotNull(clientCourse))
            {
                HttpContext.Session.SetString("CourseID", clientCourse.CourseID.ToString());
            }
            GetDropDownLists();
            return View(clientCourse);
        }

        public async Task<IActionResult> ClientFeePayment(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            ClientFee clientFee = await _service.FindClientFee(id);
            GetDropDownLists();
            if (UtilityService.IsNotNull(clientFee))
                return View(clientFee);
            return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
        }

        [HttpPost]
        public async Task<IActionResult> ClientFeePayment(ClientFee clientFee)
        {
            ClientFee update = await _service.FindClientFee(clientFee.ClientFeeID);
            if (UtilityService.IsNotNull(update))
            {
                clientFee.Amount = UtilityService.GetDecimalAmount(clientFee.InputAmount);
                int result = await _service.PayFee(clientFee);
                if (result == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClient", new { id = clientFee.ClientID });
                }
                else
                    return RedirectToAction("ViewClientTransaction", new { id = result });
            }
            return RedirectToAction("ViewClient", new { id = clientFee.ClientID });
        }


        public async Task<IActionResult> ClientCourseFeePayment(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            ClientFee clientFee = await _service.FindClientFee(id);
            GetDropDownLists();
            if (UtilityService.IsNotNull(clientFee))
                return View(clientFee);
            return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
        }




        [HttpPost]
        public async Task<IActionResult> UpdateSessions(string[] selectedSessions, ClientCourse clientCourse)
        {

            if (await (_service.UpdateSessions(clientCourse.ClientCourseID, selectedSessions)) == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            }


            return RedirectToAction("ViewClientCourse", new { id = clientCourse.ClientCourseID });

        }


        [HttpPost]
        public async Task<IActionResult> ViewClientCourse(ClientCourse clientCourse)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                ClientCourse update = await _service.FindCourse(clientCourse.ClientCourseID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(clientCourse)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return RedirectToAction("ViewClient", new { id = clientCourse.ClientID });
                    }
                }
                return RedirectToAction("ViewClientCourse", new { id = clientCourse.ClientCourseID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClientCourse", new { id = clientCourse.ClientCourseID });
        }
        public async Task<IActionResult> ActionCourse(int courseid, int Clientid)
        {
            if (await (_service.ActionCourse(courseid)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewClient", new { id = Clientid });
        }

        [HttpPost]
        public ActionResult GetCompanyList(int affiliationID)
        {

            SelectList companyList = null;
            if (affiliationID != 0)
            {
                if (affiliationID == (int)Affiliation.Company)
                {
                    companyList = GetCompanyList();
                }
            }
            return Json(companyList);

        }
        private SelectList GetCompanyList()
        {
            SelectList companyList = null;
            int clientID = 0;
            try
            {
                clientID = Convert.ToInt32(HttpContext.Session.GetString("ClientID"));
            }
            catch (Exception)
            {
                clientID = 0;
            }
            Company defaultCompany = null;
            if (clientID > 0)
            {
                defaultCompany = _service.GetClientCompany(clientID).Result;
                if (UtilityService.IsNull(defaultCompany))
                    defaultCompany = _settingService.FindDefaultCompany();
            }
            else
                defaultCompany = _settingService.FindDefaultCompany();
            List<Company> companies = _settingService.GetCompanies(true);
            if (companies != null)
            {


                companies.Select(t => new
                {
                    t.CompanyID,
                    t.Name,
                }).OrderBy(t => t.Name);

                if (UtilityService.IsNull(defaultCompany))
                    companyList = new SelectList(companies, "CompanyID", "Name");
                else
                    companyList = new SelectList(companies, "CompanyID", "Name", defaultCompany.CompanyID);
            }
            return companyList;
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

            var relationTypes = _settingService.GetRelationshipTypes();
            if (relationTypes != null)
            {
                relationTypes.Select(t => new
                {
                    t.RelationshipTypeID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.RelationTypes = new SelectList(relationTypes, "RelationshipTypeID", "Name");
            int clientID = 0;
            try
            {
                clientID = Convert.ToInt32(HttpContext.Session.GetString("ClientID"));
            }
            catch (Exception)
            {
                clientID = 0;
            }
            int dependentGenderID = 0;
            try
            {
                dependentGenderID = Convert.ToInt32(HttpContext.Session.GetString("GenderID"));
            }
            catch (Exception)
            {
                dependentGenderID = 0;
            }

            List<Product> clientproductList = null;
            if (clientID != 0)
            {
                clientproductList = _service.GetClientRegisteredProducts(clientID);

                clientproductList.Select(t => new
                {
                    t.ProductID,
                    t.Name,
                }).OrderBy(t => t.Name);

                ViewBag.RegisteredProducts = new SelectList(clientproductList, "ProductID", "Name");

            }

            else
            {
                var productList = _settingService.GetActiveProductList(); if (productList != null)
                {
                    productList.Select(t => new
                    {
                        t.ProductID,
                        t.Name,
                    }).OrderBy(t => t.Name);
                }
                ViewBag.ProductList = new SelectList(productList, "ProductID", "Name");
            }
            var allproductList = _settingService.GetActiveProductList();
            allproductList.Select(t => new
            {
                t.ProductID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.AllProductList = new SelectList(allproductList, "ProductID", "Name");



            var availableProduct = clientproductList != null ? allproductList.Except(clientproductList) : allproductList;
            if (availableProduct != null)
            {
                availableProduct.Select(t => new
                {
                    t.ProductID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }
            ViewBag.ProductsAvailable = new SelectList(availableProduct, "ProductID", "Name");


            var genderList = _settingService.GenderList(); if (genderList != null)
            {
                genderList.Select(t => new
                {
                    t.GenderID,
                    t.Name,
                }).OrderBy(t => t.Name);
            }

            ViewBag.GenderList = new SelectList(genderList, "GenderID", "Name");
            ViewBag.DependentGenderList = new SelectList(genderList, "GenderID", "Name", dependentGenderID);



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


            var courses = _settingService.GetActiveCourseList().Select(t => new
            {
                t.CourseID,
                t.Title,
            }).OrderBy(t => t.Title);

            ViewBag.CourseList = new SelectList(courses, "CourseID", "Title");


            int courseID = Convert.ToInt32(HttpContext.Session.GetString("CourseID"));
            if (courseID > 0)
            {
                var allSessions = _settingService.GetCourseOutlines(courseID).OrderBy(r => r.Name);
                var clientSessions = new HashSet<int>(_settingService.GetUserAttendedSessions(clientID, courseID)?.Select(c => c.CourseOutlineID));
                var viewModel = new List<CheckBoxListItem>();
                foreach (var session in allSessions)
                {
                    viewModel.Add(new CheckBoxListItem
                    {
                        ID = session.CourseOutlineID,
                        Name = session.Name,
                        IsChecked = clientSessions.Contains(session.CourseOutlineID)
                    });
                }
                ViewBag.SessionsList = viewModel;

            }
            else ViewBag.SessionsList = null;

            var transactionTypeList = _settingService.GetActiveTransactionTypeList().Select(t => new
            {
                t.TransactionTypeID,
                Name = t.TransType,
            }).OrderBy(t => t.Name);

            ViewBag.TransactionTypeList = new SelectList(transactionTypeList, "TransactionTypeID", "Name", (int)TransactionTypeList.Payment);


            var assertList = _settingService.GetAssertsList().Select(t => new
            {
                t.AssertID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.AssertList = new SelectList(assertList, "AssertID", "Name");


            var assertCategoryList = _settingService.GetAssertCategoryList().Select(t => new
            {
                t.AssertCategoryID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.AssertCategoryList = new SelectList(assertCategoryList, "AssertCategoryID", "Name");


            var country = _settingService.GetCountryList().Select(t => new
            {
                t.CountryID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CountryList = new SelectList(country, "CountryID", "Name");

            var statementList = _settingService.GetStatementList().Select(t => new
            {
                t.StatementID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.ClientStatement = new SelectList(statementList, "StatementID", "Name", (int)Statements.Product_Based_Statement);

            var titleList = _settingService.GetTitles().Select(t => new
            {
                t.TitleID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.TitleList = new SelectList(titleList, "TitleID", "Name");

            var clientAccountTypeList = _settingService.GetClientAccountTypes().Select(t => new
            {
                t.ID,
                t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.AccountTypes = new SelectList(clientAccountTypeList, "ID", "Name", (int)Client_AccountType.Individual);

            var intakeList = _settingService.GetCourseIntakes(true).Select(t => new
            {
                t.CourseIntakeID,
                t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.CourseIntakeList = new SelectList(intakeList, "CourseIntakeID", "Name");


            var affliationList = _settingService.GetAffiliations().Select(t => new
            {
                ID = t.ClientGroupID,
                t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.AffiliationList = new SelectList(affliationList, "ID", "Name", (int)Affiliation.Individual);


            ViewBag.CompanyList = GetCompanyList();


        }
    }
}