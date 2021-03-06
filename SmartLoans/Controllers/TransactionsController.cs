using System;
using System.Linq;
using System.Threading.Tasks;

using SmartLoan.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using SmartLogic;
using SmartDomain;
using SmartHelper;
using SmartLogic.IService;
using System.IO;
using SmartReporting;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MigraDocCore.Rendering;
using MigraDocCore.DocumentObjectModel;
using PdfSharpCore.Pdf.Security;
using SmartLog;
using SmartInterfaces;
using SmartMail;
using SmartAsync;
using SmartExtensions;

namespace SmartLoan.Controllers
{
    public class TransactionsController : BaseController<TransactionsController>
    {
        private readonly ITransactionService _service;
        private readonly ISettingService _settingService;
        private readonly IClientService _ClientService;
        private readonly IBankAccountservice _bankService;
        private readonly IEmailTemplateService _emailTemplateService;
        private Receipt receipt = null;
        public TransactionsController(ITransactionService service, IClientService ClientService, ISettingService settingService, IBankAccountservice bankService, IEmailTemplateService emailTemplateService)
        {
            _service = service;
            _ClientService = ClientService;
            _settingService = settingService;
            _bankService = bankService;
            _emailTemplateService = emailTemplateService;
        }
        public async Task<IActionResult> Transactions()
        {
            Permissions permission = Permissions.View_Payment;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });
            List<Transaction> transactions = await _service.Transactions();
            List<Transaction> _transactions = transactions.OrderByDescending(t => t.TransactionDate).ToList();
            return View(_transactions);
        }


        public IActionResult RecordPayment()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RecordPayment(PaymentViewModel paymentsFile)
        {
            if (ModelState.IsValid)
            {
                if (!_ClientService.ClientExists(paymentsFile.ClientID).Result)
                    return RedirectToAction(nameof(Transactions));

                Decimal Price = UtilityService.GetDecimalAmount(paymentsFile.Price);
                Decimal Units = UtilityService.GetDecimalAmount(paymentsFile.Units);
                Decimal TransFee = UtilityService.GetDecimalAmount(paymentsFile.TransactionalLevy);
                Decimal Fee = 0M;
                Decimal Amount = 0M;
                if (!String.IsNullOrEmpty(paymentsFile.Amount))
                    UtilityService.GetDecimalAmount(paymentsFile.Amount);
                else
                {
                    Decimal TotalPrice = Math.Round((Price * Units), 2);
                    Fee = (TotalPrice * TransFee) / 100M;
                    Amount = Math.Round((TotalPrice + Fee), 2);
                }

                Transaction addPaymentsFile = new Transaction()
                {
                    Year = paymentsFile.Year,
                    Month = paymentsFile.Month,
                    Amount = Amount,
                    Price = Price,
                    Units = Units,
                    TransactionFee = Fee,
                    TransactionRate = TransFee,
                    ClientID = paymentsFile.ClientID,
                    ProductID = paymentsFile.ProductID,
                    PaymentDate = paymentsFile.PaymentDate,
                    Narration = paymentsFile.Narration,
                    PaymentStatusID = (int)PaymentState.Paid,
                    TransactionDate = DateTime.Now,
                    ParentPaymentID = paymentsFile.ParentPaymentID,
                    LastChangedBy = UserAppData.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                    BankAccountID = paymentsFile.BankAccountID,
                    TransactionTypeID = paymentsFile.TransactionTypeID,
                    AssertID = paymentsFile.AssertID,
                    AssertCategoryID = paymentsFile.AssertCategoryID
                };
                int result = await (_service.CreatePayment(addPaymentsFile, (TransactionTypeList)paymentsFile.TransactionTypeID));
                if (result == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                else
                {
                    if (paymentsFile.AutoGenerateReceipt)
                    {
                        if (paymentsFile.AutoEmailReceipt)
                        {
                            ClientPeek statement = await _ClientService.GetClient(clientID: paymentsFile.ClientID);
                            if (statement.IsNull())
                            {
                                receipt = PrintReceipt(result);
                            }
                            else
                            {
                                receipt = PrintReceipt(result, true, statement.IDNumber);
                                if (receipt.IsNotNull())
                                {
                                    EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplate((int)EmailTypeList.Client_Statement).Result;
                                    List<AttachmentFromMemory> attachments = new List<AttachmentFromMemory>();
                                    AttachmentFromMemory attachment = new AttachmentFromMemory
                                    {
                                        FileExtension = "pdf",
                                        MemoryStream = new MemoryStream(receipt.Document),
                                        Name = UtilityService.MaskAccountNumber(statement.AccountNumber)
                                    };

                                    attachments.Add(attachment);
                                    Email email = new Email
                                    {
                                        To = statement.EmailAddress,
                                        AttachmentFromMemory = attachments
                                    };
                                    if (emailTemplate.IsNotNull())
                                    {
                                        email.Body = emailTemplate.Body;
                                        email.Subject = emailTemplate.Subject;
                                    }
                                    string emailAddress = statement.EmailAddress;
                                    bool emailSuccessResult = RabbitQueue.Publish(email);
                                    if (emailSuccessResult)
                                    {
                                        if (UserAppData.SiteEnvironment != SiteEnvironment.Production)
                                            emailAddress = $"[Test Email Address] {UtilityService.TestEmailAddress}";
                                        TempData[MessageDisplayType.Success.ToString()] = $"Email Successfully sent to {emailAddress}";
                                    }
                                    else
                                        TempData[MessageDisplayType.Error.ToString()] = $"Failed to send email to {emailAddress}";
                                }
                            }
                        }
                        else
                            receipt = PrintReceipt(result);
                        return RedirectToAction("PrintTransaction", new { id = result });
                    }

                }
            }
            int clientID = 0;
            try
            {
                clientID = Convert.ToInt32(HttpContext.Session.GetString("ClientID"));
            }
            catch (Exception)
            {
                clientID = 0;
            }
            if (clientID > 0)
                return RedirectToAction("PaidTransactions", "Client", new { id = clientID });
            else
                return RedirectToAction(nameof(Transactions));
        }

        public IActionResult AddTransaction(int ClientID)
        {
            HttpContext.Session.SetString("ClientID", ClientID.ToString());
            return RedirectToAction("RecordPayment");
        }

        public async Task<IActionResult> ViewTransaction(int id = 0, string transref = null)
        {
            GetDropDownLists();
            if (id == 0 && transref == null)
                return RedirectToAction(nameof(Transactions));
            Transaction transaction = await _service.PaymentFile(id, transref);
            return View(transaction);
        }

        [HttpGet]
        public async Task<IActionResult> ActionTransaction(int id, int transactionTypeID)
        {
            Transaction paymentsFile = await (_service.PaymentFile(id));
            if (paymentsFile.IsNotNull())
            {
                if (await (_service.ReversePayment(paymentsFile, (TransactionTypeList)transactionTypeID)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewTransaction", new { id = paymentsFile.TransactionID });
                }
            }

            return RedirectToAction(nameof(Transactions));
        }

        [HttpGet]
        public ActionResult PrintTransaction(int id)
        {
            if (id == 0)
                return RedirectToAction(nameof(Transactions));
            if (receipt == null)
            {
                receipt = PrintReceipt(id);
                if (receipt.IsNull())
                    return RedirectToAction(nameof(Transactions));
                else
                    return File(receipt.Document, "application/pdf", receipt.TransRef + ".pdf");
            }
            else
                return File(receipt.Document, "application/pdf", receipt.TransRef + ".pdf");
        }

        private Receipt PrintReceipt(int id, bool passwordProtect = false, string clientIDNumber = null)
        {
            Transaction transaction = _service.PaymentFile(id).Result;
            if (transaction.IsNotNull())
            {
                ProofOfPayment printOut = new ProofOfPayment();
                using MemoryStream stream = new MemoryStream();
                try
                {
                    Document document = printOut.Print(transaction);
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer
                    {
                        Document = document
                    };
                    pdfRenderer.RenderDocument();
                    if (UtilityService.StatementPasswordProtect && passwordProtect)
                    {
                        PdfSecuritySettings securitySettings = pdfRenderer.PdfDocument.SecuritySettings;
                        securitySettings.UserPassword = clientIDNumber;
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
                    return new Receipt() { Document = stream.ToArray(), TransRef = transaction.TransRef };
                }
                catch (Exception ex)
                {
                    CustomLog.Log(LogSource.GUI, ex);
                }
            }
            return null;
        }

        [HttpGet]
        public ActionResult GenerateInvoice()
        {
            Permissions permission = Permissions.View_Invoice;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            GetDropDownLists();
            return View();
        }

        [HttpGet]
        public ActionResult CreateInvoice(ScheduleModel model)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("InvoiceDate", model.InvoiceDate.ToString());
                HttpContext.Session.SetString("DueDate", model.DueDate.ToString());
                HttpContext.Session.SetString("ProductID", model.ProductID.ToString());
                bool invoiceIsDuplicate = _service.InvoiceIsDuplicate(model.DueDate, model.InvoiceDate, model.ProductID);
                if (invoiceIsDuplicate)
                {
                    TempData["Error"] = $"Invoice with due date {UtilityService.ShowDate(model.DueDate)} and invoice date {UtilityService.ShowDate(model.InvoiceDate)} already exists, you can either delete the invoice and start over or generate a new invoice with different date parameters.";
                    return RedirectToAction(nameof(GenerateInvoice));
                }
                //1.Create Invoice and Assign Status Created
                int result = _service.CreateInvoice(model.InvoiceDate, model.DueDate, model.ProductID).Result;
                if (result > 0)
                    return RedirectToAction("ViewInvoice", new { id = result });

            }
            return RedirectToAction(nameof(GenerateInvoice));
        }
        [HttpGet]
        public ActionResult ProcessInvoice(int id)
        {
            var invoice = _service.GetInvoice(id);
            if (invoice.IsNull())
                return RedirectToAction(nameof(GenerateInvoice));
           // var clients = null;// _ClientService.GetPotentialInvoiceEntries(invoice.InvoiceID, invoice.ProductID ?? 0, invoice.InvoiceDate);
            return View(null);
        }

        [HttpGet]
        public IActionResult Invoices()
        {
            GetDropDownLists();
            return View();
        }

        [HttpPost]
        public IActionResult GeneratedInvoices(ScheduleModel model)
        {
            HttpContext.Session.SetString("DateFrom", model.DateFrom.ToString());
            HttpContext.Session.SetString("DateTo", model.DateTo.ToString());
            var invoices = _service.GetInvoices(model.DateFrom, model.DateTo);
            return View(invoices);

        }
        [HttpGet]
        public IActionResult InvoiceDetails(int id)
        {
            HttpContext.Session.SetString("InvoiceID", id.ToString());
            var deductions = _service.GetInvoiceDetail(id);
            deductions.InvoiceTitle = $"Invoice Entries for Invoice Number - {id}";
            return View(deductions);
        }
        [HttpPost]
        public ActionResult DeleteInvoiceEntries(IFormCollection formCollection)
        {
            var clientDeductionIDs = formCollection["InvoiceDetailID"];
            List<int> clientDeductionsDetails = new List<int>();
            int clientDeductionID = 0;
            foreach (string id in clientDeductionIDs)
            {
                clientDeductionsDetails.Add(int.Parse(id));

            }
            if (clientDeductionsDetails.Count() > 0)
            {
                int result = _service.RemoveInvoiceEntries(clientDeductionsDetails).Result;
                if (result > 0)
                {
                    try
                    {
                        clientDeductionID = Convert.ToInt32(HttpContext.Session.GetString("InvoiceID"));
                    }
                    catch
                    {
                    }
                    TempData[MessageDisplayType.Success.ToString()] = $"{clientDeductionsDetails.Count()} removed successfully";

                    if (clientDeductionID > 0)
                        return RedirectToAction("InvoiceDetails", new { clientDeductionID });
                }
            }
            return RedirectToAction(nameof(Invoices));
        }
        public ActionResult ViewInvoice(int id)
        {
            Invoice deduction = _service.GetInvoice(id);
            if (deduction.IsNull())
                return RedirectToAction(nameof(Invoices));
            return View(deduction);
        }

        [HttpGet]
        public ActionResult DeleteInvoice(int id)
        {
            bool invoiceHasEntries = _service.InvoiceHasEntries(id);
            if (invoiceHasEntries)
            {
                TempData[MessageDisplayType.Error.ToString()] = $"Failed to delete invoice {id} there are entries linked to it.";
                return RedirectToAction("ViewInvoice", new { id });
            }
            int result = _service.RemoveInvoice(id);
            return RedirectToAction(nameof(Invoices));
        }

        [HttpGet]
        public ActionResult FinaliseInvoice(int id)
        {
            int result = _service.FinaliseInvoice(id);
            if (result == 0)
                TempData[MessageDisplayType.Error.ToString()] = $"Failed to finalise invoice {id}.";
            return RedirectToAction("ViewInvoice", new { id });
        }

        [HttpPost]
        public ActionResult ProcessEntries(IFormCollection formCollection)
        {
            int invoiceID = 0;
            Invoice invoice = null;
            var clientProductIDs = formCollection["ClientProductID"];
            var InvoiceID = formCollection["InvoiceID"];
            try
            {
                invoiceID = Int32.Parse(InvoiceID);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.GUI, ex);
            }
            if (invoiceID > 0)
            {
                invoice = _service.GetInvoice(invoiceID);
                if (invoice.IsNull())
                    return RedirectToAction(nameof(GenerateInvoice));
                HttpContext.Session.SetString("InvoiceID", invoiceID.ToString());
            }
            bool isDuplicateInvoiceEntries = _service.InvoiceEntriesIsDuplicate(invoiceID);
            if (isDuplicateInvoiceEntries)
            {
                TempData["Error"] = $"Invoice {invoice.InvoiceID}  with due date {UtilityService.ShowDate(invoice.DueDate)} and invoice date {UtilityService.ShowDate(invoice.InvoiceDate)} already has entries that have been processed, you can either delete the invoice or its entries and start over or generate another invoice with different parameters.";
                return RedirectToAction(nameof(GenerateInvoice));
            }
            List<int> clientProductID = new List<int>();
            foreach (string id in clientProductIDs)
                clientProductID.Add(int.Parse(id));
            if (clientProductID.Count() > 0)
            {
                invoiceID = 0;// _service.ProcessInvoice(clientProductID, invoiceID);
                var invoiceDetails = _service.GetInvoiceDetails(clientProductID, invoice.InvoiceDate).Result;
                TempData["Title"] = $"Invoice Entries for Invoice Number - {invoiceID}";

                return View(invoiceDetails);
            }
            return RedirectToAction(nameof(GenerateInvoice));
        }

        [HttpGet]
        public ActionResult PrintSchedule(int id)
        {
            if (id == 0)
            {
                try
                {
                    id = Convert.ToInt32(HttpContext.Session.GetString("InvoiceID"));
                }
                catch
                {
                }
            }
            Company company = _settingService.FindDefaultCompany();
            Invoice clientDeduction = _service.GetInvoice(id);
            SmartReporting.InvoiceSchedule printOut = new SmartReporting.InvoiceSchedule();
            using MemoryStream stream = new MemoryStream();
            Document document = printOut.Print(company, clientDeduction);
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer
            {
                Document = document
            };
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(stream, false);
            return File(stream.ToArray(), "application/pdf", $"SalarySchedule.pdf");
        }


        [HttpPost]
        public ActionResult CustomisedSchedule(IFormCollection formCollection)
        {

            int invoiceID = 0;
            Invoice invoice = null;
            var invoiceDetailIDs = formCollection["InvoiceDetailID"];
            var InvoiceID = formCollection["InvoiceID"];
            try
            {
                invoiceID = Int32.Parse(InvoiceID);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.GUI, ex);
            }
            if (invoiceID > 0)
            {
                invoice = _service.GetInvoice(invoiceID);
                if (invoice.IsNull())
                    return RedirectToAction(nameof(GenerateInvoice));
                HttpContext.Session.SetString("InvoiceID", invoiceID.ToString());
            }
            List<InvoiceDetails> details = invoice.InvoiceDetails;
            if (details != null && details.Count > 0)
            {
                invoice.InvoiceDetails = null;
                List<int> invoiceDetailID = new List<int>();
                foreach (string id in invoiceDetailIDs)
                    invoiceDetailID.Add(int.Parse(id));
                if (invoiceDetailID.Count() > 0)
                {
                    List<InvoiceDetails> result = details
                    .Where(d => invoiceDetailIDs.ToString().Contains(d.InvoiceDetailID.ToString()))
                    .ToList();
                    invoice.InvoiceDetails = result;
                }
            }
            Company company = _settingService.FindDefaultCompany();
            InvoiceSchedule printOut = new InvoiceSchedule();
            using MemoryStream stream = new MemoryStream();
            Document document = printOut.Print(company, invoice);
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer
            {
                Document = document
            };
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(stream, false);
            return File(stream.ToArray(), "application/pdf", $"SalarySchedule.pdf");
        }
        private void GetDropDownLists()
        {
            var paymentLists = _settingService.GetActiveProductList().Select(t => new
            {
                t.ProductID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.ProductList = new SelectList(paymentLists, "ProductID", "Name");
            int clientID = 0;
            try
            {
                clientID = Convert.ToInt32(HttpContext.Session.GetString("ClientID"));
            }
            catch (Exception)
            {
                clientID = 0;
            }
            var ClientList = _ClientService.Clients().Select(t => new
            {
                t.ClientID,
                Name = $" {t.ClientFullName} - {t.AccountNumber}",
            }).OrderBy(t => t.Name);
            ViewBag.ClientList = new SelectList(ClientList, "ClientID", "Name", clientID);

            var bankList = _bankService.Banks().Result.Select(t => new
            {
                t.BankAccountID,
                Name = t.AccountName.ToString(),
            }).OrderBy(t => t.Name);

            ViewBag.BankAccountList = new SelectList(bankList, "BankAccountID", "Name");

            var transactionTypeList = _settingService.GetActiveTransactionTypeList().Select(t => new
            {
                t.TransactionTypeID,
                Name = t.TransType,
            }).OrderBy(t => t.Name);

            ViewBag.TransactionTypeList = new SelectList(transactionTypeList, "TransactionTypeID", "Name", (int)TransactionTypeList.Payment);

            var productList = _settingService.GetActiveProductList().Select(t => new
            {
                t.ProductID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.ProductList = new SelectList(productList, "ProductID", "Name");
       
        }

        
    }
}
