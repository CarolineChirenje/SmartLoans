using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Http;
using SmartLoan.Models;
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
using SmartInterfaces;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf.IO;
using PdfSharpCore.Pdf;
using SmartMail;
using SmartAsync;
using SmartExtensions;

namespace SmartLoan.Controllers
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
        readonly IFeatureFlagService _featureFlagService;
        private readonly IEmailTemplateService _emailTemplateService;

        public ClientController(IClientService service, IUserService userService, IDocumentTypeService documentTypeService,
        ISettingService settingService, ITransactionService paymentService,
        IBankAccountservice bankService, IDepartmentService departmentService,
        IFeatureFlagService featureFlagService, IEmailTemplateService emailTemplateService)
        {
            _service = service;
            _userService = userService;
            _documentTypeService = documentTypeService;
            _settingService = settingService;
            _paymentService = paymentService;
            _bankService = bankService;
            _departmentService = departmentService;
            _featureFlagService = featureFlagService;
            _emailTemplateService = emailTemplateService;
        }

        [OverrideMenuComponentFilter]
     public ActionResult Clients(string accountNum = null, bool newClientsOnly = false, int productID = 0, int companyID = 0)
        {
            try
            {
                Permissions permission = Permissions.View_Client;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });
                if (UserAppData.CurrentUserTypeID == (int)TypeOfUser.Employee)
                    return RedirectToAction("Dashboard", "External");
                if (UserAppData.CurrentUserTypeID == (int)TypeOfUser.Employer && UserAppData.CompanyID > 0)
                    companyID = UserAppData.CompanyID;
                List<ClientList> Clients = _service.Clients(accountNum, newClientsOnly, productID, companyID);

                return View(Clients);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }


        }
        public ActionResult Birthdays()
        {
            try
            {
                Permissions permission = Permissions.View_Client;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });
                if (UserAppData.CurrentUserTypeID == (int)TypeOfUser.Employee)
                    return RedirectToAction("Dashboard", "External");

                List<ClientList> Clients = _service.Birthdays();

                return View(Clients);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }


        }

        public IActionResult MyAccount()
        {
            if (UserAppData.CurrentUserTypeID == (int)TypeOfUser.Employee)
            {
                BasicDetail user = _userService.GetUser(username: UserAppData.CurrentUserName);
                if (user.IsNotNull())
                {
                    ClientPeek client = _service.GetClient(user.EmailAddress, user.IDNumber).Result;
                    if (client.IsNotNull())
                    {
                        return RedirectToAction("ViewClient", "Client", new { id = client.ClientID });
                    }
                    else
                    {
                        TempData["Error"] = "No records found";

                        return RedirectToAction("Dashboard", "External");
                    }
                }
                else
                    return RedirectToAction("Dashboard", "External");
            }
            return RedirectToAction("Dashboard", "Home");
        }


        public ActionResult Loans(int id)
        {
            try
            {
                Permissions permission = Permissions.View_Client_Loan;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });
                ClientLoans client = _service.GetClientLoans(id).Result;
                return View(client);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }


        }
        public IActionResult AddClient()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddClient(ClientForm client)
        {
            GetDropDownLists();
            decimal _salary = UtilityService.GetDecimalAmount(client.SalaryAmount);
            client.Salary = _salary;
            int _result = await (_service.Save(client));
            if (_result == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(client);
            }
            return RedirectToAction("ViewClient", new { id = _result });
        }

        public async Task<IActionResult> ViewClient(int id = 0, string accountNum = null)
        {
            var _tempData = TempData["Error"];

            HttpContext.Session.SetString("ClientID", id.ToString());

            if (id == 0 && accountNum == null)
                return RedirectToAction(nameof(Clients));
            ClientForm client = await _service.FindClient(id);
            if (client.IsNotNull())
            {
                HttpContext.Session.SetString("ClientID", client.ClientID.ToString());
                GetDropDownLists();
                return View(client);
            }
            else
                return RedirectToAction(nameof(Clients));
        }
        public ActionResult SalaryHistory(int id)
        {
            try
            {
                GetDropDownLists();
                SalaryHistory history = _service.SalaryHistory(id);
                if (history.IsNull())
                    return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

                return View(history);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> ViewClient(ClientForm client)
        {
            GetDropDownLists();
            decimal _salary = UtilityService.GetDecimalAmount(client.SalaryAmount);
            client.Salary = _salary;
            if (ModelState.IsValid)
            {
                ClientForm update = await _service.FindClient(client.ClientID);
                if (update.IsNotNull())
                {
                    if (await (_service.Update(client)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(client);
                    }
                }
                return RedirectToAction("ViewClient", new { id = client.ClientID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(client);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Clients));
            else
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewClient", new { id });
            }
        }

        //Contact
        public ActionResult Contacts(int id)
        {
            Permissions permission = Permissions.View_Client_Contact;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });
            try
            {
                GetDropDownLists();
                Contacts contacts = _service.ClientContacts(id);
                if (contacts.IsNull())
                    return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

                return View(contacts);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddClientContact(ClientContact ClientContact)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(ClientContact)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            }
            return RedirectToAction("Contacts", new { id = ClientContact.ClientID });
        }
        public async Task<IActionResult> ViewContact(int id)
        {
            if (id == 0)
                return RedirectToAction("Contacts", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            GetDropDownLists();
            var ClientContact = await _service.FindContact(id);
            return View(ClientContact);
        }

        [HttpPost]
        public async Task<IActionResult> ViewContact(ClientContact clientContact)
        {
            if (clientContact.IsNotNull())
            {
                GetDropDownLists();
                int clientContactID = clientContact.ClientContactID;
                ClientContact update = await _service.FindContact(clientContactID);
                if (update.IsNotNull())
                {
                    if (await (_service.Update(clientContact)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                }
                return RedirectToAction("ViewContact", new { id = clientContactID });
            }
            return RedirectToAction("Contacts", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

        }

        public async Task<IActionResult> ActionContact(int contactid, int Clientid)
        {
            if (await (_service.ActionContact(contactid, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("Contacts", new { id = Clientid });
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
                Permissions permission = Permissions.View_Client_Note;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                Comments comments = _service.ClientNotes(id);
                return View(comments);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
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
            return RedirectToAction("Notes", new { id = ClientNote.ClientID });
        }
        public async Task<IActionResult> ViewClientNote(int id)
        {
            if (id == 0)
                return RedirectToAction("Notes", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
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
                if (update.IsNotNull())
                {
                    if (await (_service.Update(ClientNote)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewClientNote", new { id = ClientNote.ClientID });
                }
                return RedirectToAction("Notes", new { id = ClientNote.ClientID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClientNote", new { id = ClientNote.ClientNoteID });
        }
        public async Task<IActionResult> ActionNote(int noteid, int Clientid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("Notes", new { id = Clientid });
        }
        public async Task<IActionResult> CloseNote(int noteid, int Clientid)
        {
            if (await (_service.ActionNote(noteid, DatabaseAction.Close)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("Notes", new { id = Clientid });
        }

        /// <summary>
        /// Client Document
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Documents(int id)
        {
            try
            {
                Permissions permission = Permissions.Client_View_Document;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                Docs document = _service.ClientDocuments(id);
                return View(document);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddClientDocument(ClientDocument ClientDocument, IFormFile FileBytes)
        {
            if (ModelState.IsValid)
            {
                bool documentUploaded = await _service.DocumentUploaded(ClientDocument.ClientID, ClientDocument.DocumentTypeID);
                if (documentUploaded)
                {
                    TempData["Error"] = "A  document of the same type has already been uploaded in the system.Please delete the existing document before trying to  re-upload";
                    return RedirectToAction("Documents", new { id = ClientDocument.ClientID });
                }

                Custom documentInformation = _settingService.DocumentFormatMatch(FileBytes.ContentType, ClientDocument.DocumentTypeID);
                if (!documentInformation.Bool_Value)
                {
                    TempData["Error"] = $"Document Type MisMatch {documentInformation.String_Value} required";
                    return RedirectToAction("Documents", new { id = ClientDocument.ClientID });
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
            return RedirectToAction("Documents", new { id = ClientDocument.ClientID });
        }
        public async Task<IActionResult> ViewClientDocument(int id = 0)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction("Documents", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });

            return View(await _service.FindDocument(id));
        }
        [HttpPost]
        public async Task<IActionResult> ViewClientDocument(ClientDocument ClientDocument)
        {
            if (ModelState.IsValid)
            {
                ClientDocument update = await _service.FindDocument(ClientDocument.ClientDocumentID);
                if (update.IsNotNull())
                {
                    if (await (_service.Update(update)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                }
                return RedirectToAction("ViewClient", new { id = ClientDocument.ClientDocumentID });
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewClientDocument", new { id = ClientDocument.ClientDocumentID });
        }
        public async Task<IActionResult> ActionDocument(int id)
        {
            if (await (_service.ActionDocument(id, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewClientDocument", new { id });
            }
            return RedirectToAction("Documents", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
        }
        [HttpGet]
        public async Task<FileResult> DownloadDocument(int id)
        {
            ClientDocument document = await _service.FindDocument(id);
            return File(document.FileBytes, document.FileType, document.FileName);
        }
        public ActionResult Statements(int id)
        {
            try
            {
                Permissions permission = Permissions.Generate_Client_Statement;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                Statement statement = null;// _service.ClientStatements(id);
                if (statement.IsNull())
                    return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
                var statementList = _settingService.GetStatementList().Select(t => new
                {
                    t.StatementID,
                    t.Name,
                }).OrderBy(t => t.Name);

                ViewBag.ClientStatement = new SelectList(statementList, "StatementID", "Name", (int)SmartHelper.Statements.Product_Based_Statement);
                ViewBag.RegisteredProducts = new SelectList(statement.ProductList, "ProductID", "Name");

                return View(statement);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public ActionResult GenerateStatementAsync(IFormCollection formCollection)
        {
            var _clientID = formCollection["ClientID"];
            bool emailStatement = false;
            bool printReversalsOnStatement = false;
            int ClientID = 0;
            int ProductID = 0;
            int StatementID = 0;
            DateTime startDate = DateTime.Now.AddMonths(-1);
            DateTime endDate = DateTime.Now.AddMonths(1);
            try
            {

                ClientID = Int32.Parse(_clientID);

            }
            catch (Exception)
            {
            }
            try
            {
                ProductID = Int32.Parse(formCollection["ProductID"]);

            }
            catch (Exception)
            {
            }
            try
            {
                StatementID = Int32.Parse(formCollection["StatementID"]);

            }
            catch (Exception)
            {
            }
            try
            {
                printReversalsOnStatement = Boolean.Parse(formCollection["PrintReversalsOnStatement"]);
            }
            catch (Exception)
            {
            }
            try
            {
                startDate = DateTime.Parse(formCollection["StartDate"]);
            }
            catch (Exception)
            {
            }
            try
            {
                endDate = DateTime.Parse(formCollection["EndDate"]);
            }
            catch (Exception)
            {
            }
            try
            {
                emailStatement = Boolean.Parse(formCollection["EmailStatement"]);
            }
            catch (Exception)
            {
            }
            if (StatementID == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = $"Please Select Statement!";
                return RedirectToAction("Statements", new { id = ClientID });
            }
            if (ClientID == 0)
                return RedirectToAction(nameof(Clients));
            Statement statement = new Statement
            {
                ClientID = ClientID,
                ProductID = ProductID,
                StartDate = startDate,
                EndDate = endDate,
                PrintReversalsOnStatement = printReversalsOnStatement,
                StatementID = StatementID
            };
            statement.Client = _service.FindClient(statement.ClientID).Result;
            statement.Product = _settingService.FindProduct(statement.ProductID);
            string filename = statement.Client.AccountNumber;
            ClientStatement printOut = new ClientStatement();
            byte[] pdfFile = GeneratePDFStatement(statement, emailStatement);
            if (!emailStatement)
                return File(pdfFile, "application/pdf", filename + ".pdf");
            else
            {
                EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplate((int)EmailTypeList.Client_Statement).Result;
                List<AttachmentFromMemory> attachments = new List<AttachmentFromMemory>();
                AttachmentFromMemory attachment = new AttachmentFromMemory
                {
                    FileExtension = "pdf",
                    MemoryStream = new MemoryStream(pdfFile),
                    Name = UtilityService.MaskAccountNumber(filename)
                };

                attachments.Add(attachment);
                Email email = new Email
                {
                    To = statement.Client.EmailAddress,
                    AttachmentFromMemory = attachments
                };
                if (emailTemplate.IsNotNull())
                {
                    email.Body = emailTemplate.Body;
                    email.Subject = emailTemplate.Subject;
                }
                string emailAddress = statement.Client.EmailAddress;
                bool emailSuccessResult = RabbitQueue.Publish(email);
                if (emailSuccessResult)
                {
                    if (UserAppData.SiteEnvironment != SiteEnvironment.Production)
                    {
                        if (UserAppData.GrantAccessToTestEnvironment)
                            emailAddress = $"[Test Email Address] {UserAppData.UserEmailAddress}";
                        else
                            emailAddress = $"[Test Email Address] {UtilityService.TestEmailAddress}";
                    }
                    TempData[MessageDisplayType.Success.ToString()] = $"Email Successfully sent to {emailAddress}";
                }
                else
                {
                    if (UserAppData.SiteEnvironment != SiteEnvironment.Production)
                    {
                        if (UserAppData.GrantAccessToTestEnvironment)
                            emailAddress = $"[Test Email Address] {UserAppData.UserEmailAddress}";
                        else
                            emailAddress = $"[Test Email Address] {UtilityService.TestEmailAddress}"; ;
                    }
                    TempData[MessageDisplayType.Error.ToString()] = $"Failed to send email to {emailAddress}";
                }
                return RedirectToAction("Statements", new { id = statement.ClientID });
            }
        }

        [HttpPost]
        public ActionResult OustandingStatementAsync(IFormCollection formCollection)
        {
            var _clientID = formCollection["ClientID"];
            bool emailStatement = false;
            int ClientID = 0;
            try
            {
                ClientID = Int32.Parse(_clientID);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.GUI, ex);
            }

            try
            {
                emailStatement = Boolean.Parse(formCollection["EmailStatement"]);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.GUI, ex);
            }
            if (ClientID == 0)
                return RedirectToAction(nameof(Clients));
            OutstandingStatement statement = new OutstandingStatement
            {
                ClientID = ClientID
            };
            statement.Client = _service.FindClient(statement.ClientID).Result;
            string filename = statement.Client.AccountNumber;
            byte[] pdfFile = GeneratePDFOutstandingPaymentsStatement(statement, emailStatement);
            if (!emailStatement)
                return File(pdfFile, "application/pdf", filename + ".pdf");

            else
            {
                EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplate((int)EmailTypeList.Client_Statement).Result;
                List<AttachmentFromMemory> attachments = new List<AttachmentFromMemory>();
                AttachmentFromMemory attachment = new AttachmentFromMemory
                {
                    FileExtension = "pdf",
                    MemoryStream = new MemoryStream(pdfFile),
                    Name = UtilityService.MaskAccountNumber(filename)
                };

                attachments.Add(attachment);

                Email email = new Email
                {
                    To = statement.Client.EmailAddress,
                    AttachmentFromMemory = attachments
                };
                if (emailTemplate.IsNotNull())
                {
                    email.Body = emailTemplate.Body;
                    email.Subject = emailTemplate.Subject;
                }
                string emailAddress = statement.Client.EmailAddress;
                bool emailSuccessResult = RabbitQueue.Publish(email);
                if (emailSuccessResult)
                {
                    if (UserAppData.SiteEnvironment != SiteEnvironment.Production)
                        emailAddress = $"[Test Email Address] {UtilityService.TestEmailAddress}";
                    TempData[MessageDisplayType.Success.ToString()] = $"Email Successfully sent to {emailAddress}";
                }
                else
                {
                    if (UserAppData.SiteEnvironment != SiteEnvironment.Production)
                        emailAddress = $"[Test Email Address] {UtilityService.TestEmailAddress}";
                    TempData[MessageDisplayType.Error.ToString()] = $"Failed to send email to {emailAddress}";
                }
                return RedirectToAction("PendingTransactions", new { id = statement.ClientID });
            }
        }
        private byte[] GeneratePDFStatement(Statement statement, bool isEmail)
        {
            byte[] pdffile = null;
            ClientStatement printOut = new ClientStatement();

            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    Document document = printOut.Print(statement);
                    // Create a renderer for the MigraDoc document.
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer
                    {
                        // Associate the MigraDoc document with a renderer
                        Document = document
                    };
                    // Layout and render document to PDF
                    pdfRenderer.RenderDocument();
                    pdfRenderer.PdfDocument.Save(stream, false);
                    byte[] finalDocument = ProcessPDF(stream.ToArray(), statement.Client.IDNumber.Trim(), isEmail);
                    pdffile = finalDocument;
                }
                catch (Exception ex)
                {

                    CustomLog.Log(LogSource.GUI, ex);
                }

            }
            return pdffile;
        }
        private byte[] GeneratePDFOutstandingPaymentsStatement(OutstandingStatement statement, bool isEmail)
        {
            byte[] pdffile = null;
            OutstandingPayments printOut = new OutstandingPayments();

            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    Document document = printOut.Print(statement);
                    // Create a renderer for the MigraDoc document.
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer
                    {
                        // Associate the MigraDoc document with a renderer
                        Document = document
                    };

                    // Layout and render document to PDF
                    pdfRenderer.RenderDocument();
                    pdfRenderer.PdfDocument.Save(stream, false);
                    byte[] finalDocument = ProcessPDF(stream.ToArray(), statement.Client.IDNumber.Trim(), isEmail);
                    pdffile = finalDocument;

                }
                catch (Exception ex)
                {

                    CustomLog.Log(LogSource.GUI, ex);
                }

            }

            return pdffile;
        }

        private byte[] ProcessPDF(byte[] documentGenerated, string IDNumber, bool isEmail)
        {
            MemoryStream stream = new MemoryStream(0);
            stream.Write(documentGenerated, 0, documentGenerated.Length);
            var document = PdfReader.Open(stream, UtilityService.StatementPasswordForAdmin.Trim(), PdfDocumentOpenMode.Modify);

            if (UserAppData.SiteEnvironment != SiteEnvironment.Production)
            {
                const int emSize = 100;
                string watermark = $"{UserAppData.SiteEnvironment}";
                // Create the font for drawing the watermark.
                var font = new XFont("Times New Roman", emSize, XFontStyle.BoldItalic);
                //this makes _mem resizeable 

                // var document = PdfReader.Open(stream, PdfDocumentOpenMode.Modify);
                // Set version to PDF 1.4 (Acrobat 5) because we use transparency.
                if (document.Version < 14)
                    document.Version = 14;

                for (var idx = 0; idx < document.Pages.Count; idx++)
                {
                    var page = document.Pages[idx];

                    // Variation 1: Draw a watermark as a text string.
                    // Get an XGraphics object for drawing beneath the existing content.
                    var gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Prepend);

                    // Get the size (in points) of the text.
                    var size = gfx.MeasureString(watermark, font);

                    // Define a rotation transformation at the center of the page.
                    gfx.TranslateTransform(page.Width / 2, page.Height / 2);
                    gfx.RotateTransform(-Math.Atan(page.Height / page.Width) * 180 / Math.PI);
                    gfx.TranslateTransform(-page.Width / 2, -page.Height / 2);

                    // Create a string format.
                    var format = new XStringFormat
                    {
                        Alignment = XStringAlignment.Near,
                        LineAlignment = XLineAlignment.Near
                    };

                    // Create a dimmed red brush.
                    XBrush brush = new XSolidBrush(XColor.FromArgb(128, 255, 0, 0));

                    // Draw the string.
                    gfx.DrawString(watermark, font, brush,
                        new XPoint((page.Width - size.Width) / 2, (page.Height - size.Height) / 2),
                        format);

                }
            }

            if (UtilityService.StatementPasswordProtect && isEmail)
            {
                PdfSecuritySettings securitySettings = document.SecuritySettings;

                // Setting one of the passwords automatically sets the security level to 
                // PdfDocumentSecurityLevel.Encrypted128Bit.
                securitySettings.UserPassword = IDNumber;
                securitySettings.OwnerPassword = UtilityService.StatementPasswordForAdmin.Trim();

                // Don't use 40 bit encryption unless needed for compatibility
                //securitySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted40Bit;

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
            document.Save(stream, false);
            var _document = stream.ToArray();
            return _document;
        }

        /// <summary>
        /// Client Payment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        public ActionResult PaidTransactions(int id)
        {
            try
            {
                Permissions permission = Permissions.View_Client_Payments;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                Transactions transactions = null; //_service.PaidTransactions(id);
                if (transactions.IsNull())
                    return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
                return View(transactions);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpGet]
        public ActionResult PendingTransactions(int id)
        {
            try
            {
                Permissions permission = Permissions.View_Client_Outstanding_Payments;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                PendingTransactions transactions = null;// _service.PendingTransactions(id, DateTime.Now.AddDays(30));
                if (transactions.IsNull())
                    return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
                return View(transactions);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpGet]

        [HttpPost]
        public async Task<IActionResult> AddTransaction(Transaction payment)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                ClientForm clientForm = await _service.FindClient(payment.ClientID);
                if (clientForm.IsNotNull())
                {
                    if (await (_paymentService.CreatePayment(payment, (TransactionTypeList)payment.TransactionTypeID)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return RedirectToAction("ViewClient", new { id = payment.ClientID });
                    }
                }
            }
            return RedirectToAction("ViewClient", new { id = payment.ClientID });
        }

        // GET:
        public async Task<IActionResult> ViewClientTransaction(int id)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction("PaidTransactions", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
            Transaction transaction = await _paymentService.PaymentFile(id, null);
            return View(transaction);
        }

        [HttpGet]
        public async Task<IActionResult> ActionTransaction(int id, int transactionTypeID, int clientid)
        {
            Transaction paymentsFile = await (_paymentService.PaymentFile(id));
            if (paymentsFile.IsNotNull())
            {
                if (await (_paymentService.ReversePayment(paymentsFile, (TransactionTypeList)transactionTypeID)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
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
                if (paymentsFile.IsNotNull())
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




        //Dependent Details
        public ActionResult Dependents(int id)
        {
            try
            {
                Permissions permission = Permissions.View_Client_Dependent;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                GetDropDownLists();
                Dependents dependents = _service.ClientDependents(id);
                if (dependents.IsNull())
                    return RedirectToAction("ViewClient", new { id = Convert.ToInt32(HttpContext.Session.GetString("ClientID")) });
                return View(dependents);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddClientDependent(ClientDependent ClientDependent)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(ClientDependent)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("Dependents", new { id = ClientDependent.ClientID });
        }

        public async Task<IActionResult> ViewClientDependent(int id, int Clientid)
        {
            if (id == 0)
                return RedirectToAction("Dependents", new { id = Clientid });

            ClientDependent ClientDependent = await _service.FindDependent(id);
            if (ClientDependent.IsNull())
                return RedirectToAction("Dependents", new { id = Clientid });
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
                if (update.IsNotNull())
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
            return RedirectToAction("Dependents", new { id = ClientDependent.ClientID });
        }
        [HttpGet]
        public async Task<IActionResult> ActionDependent(int Dependentid, int Clientid)
        {
            if (await (_service.ActionDependent(Dependentid, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewClientDependent", new { id = Dependentid });
            }
            return RedirectToAction("Dependents", new { id = Clientid });
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
                if (defaultCompany.IsNull())
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

                if (defaultCompany.IsNull())
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





            var transactionTypeList = _settingService.GetActiveTransactionTypeList().Select(t => new
            {
                t.TransactionTypeID,
                Name = t.TransType,
            }).OrderBy(t => t.Name);

            ViewBag.TransactionTypeList = new SelectList(transactionTypeList, "TransactionTypeID", "Name", (int)TransactionTypeList.Payment);


            var country = _settingService.GetCountryList().Select(t => new
            {
                t.CountryID,
                t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.CountryList = new SelectList(country, "CountryID", "Name");
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