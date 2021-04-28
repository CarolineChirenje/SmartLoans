﻿using System;
using System.Linq;
using System.Threading.Tasks;

using SmartSave.Models;
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

namespace SmartSave.Controllers
{
    public class TransactionsController : BaseController<TransactionsController>
    {
        private readonly ITransactionService _service;
        private readonly ISettingService _settingService;
        private readonly IClientService _ClientService;
        private readonly IBankAccountservice _bankService;
        private readonly IEmailTemplateService _emailTemplateService;
        readonly IMailService _mailService;
        private Receipt receipt = null;
        public TransactionsController(ITransactionService service, IClientService ClientService, ISettingService settingService, IBankAccountservice bankService, IEmailTemplateService emailTemplateService, IMailService mailService)
        {
            _service = service;
            _ClientService = ClientService;
            _settingService = settingService;
            _bankService = bankService;
            _emailTemplateService = emailTemplateService;
            _mailService = mailService;
        }

        public async Task<IActionResult> Transactions()
        {
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
                Decimal Amount = UtilityService.GetDecimalAmount(paymentsFile.Amount);

                Transaction addPaymentsFile = new Transaction()
                {
                    Year = paymentsFile.Year,
                    Month = paymentsFile.Month,
                    Amount = Amount,
                    ClientID = paymentsFile.ClientID,
                    ProductID = paymentsFile.ProductID,
                    PaymentDate = paymentsFile.PaymentDate,
                    Narration = paymentsFile.Narration,
                    PaymentStatusID = (int)PaymentState.Paid,
                    TransactionDate = DateTime.Now,
                    ParentPaymentID = paymentsFile.ParentPaymentID,
                    LastChangedBy = UtilityService.CurrentUserName,
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
                            Client statement = await _ClientService.FindClientSuperFast(paymentsFile.ClientID);
                            if (UtilityService.IsNull(statement))
                            {
                                receipt = PrintReceipt(result);
                            }
                            else
                            {
                                receipt = PrintReceipt(result, true, statement.IDNumber);
                                if (UtilityService.IsNotNull(receipt))
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
                                    Email email = new Email();
                                    email.To = statement.EmailAddress;
                                    email.AttachmentFromMemory = attachments;
                                    if (UtilityService.IsNotNull(emailTemplate))
                                    {
                                        email.Body = emailTemplate.Body;
                                        email.Subject = emailTemplate.Subject;
                                    }
                                    string emailAddress = statement.EmailAddress;
                                    if (_mailService.SendMail(email))
                                    {
                                        if (UtilityService.SiteEnvironment != SiteEnvironment.Production)
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
                return RedirectToAction("ViewClient", "Client", new { id = clientID });
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
            if (UtilityService.IsNotNull(paymentsFile))
            {
                if (await (_service.ReversePayment(paymentsFile, (TransactionTypeList)transactionTypeID)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewTransaction", new { paymentsFile.TransactionID });
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
                if (UtilityService.IsNull(receipt))
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
            if (UtilityService.IsNotNull(transaction))
            {
                ProofOfPayment printOut = new ProofOfPayment();
                using (MemoryStream stream = new MemoryStream())
                {
                    try
                    {
                        Document document = printOut.Print(transaction);
                        PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                        pdfRenderer.Document = document;
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
            }
            return null;
        }

        [HttpGet]
        public ActionResult BulkInvoices()
        {
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
                if (_service.DeductionExists(model.DueDate, model.InvoiceDate))
                {
                    TempData["Error"] = $"Invoices with due date {UtilityService.ShowDate(model.DueDate)} and invoice date {UtilityService.ShowDate(model.InvoiceDate)} have already been generated, you can either deleted the invoices and start over or generate invoices with different parameters.";
                    return RedirectToAction(nameof(BulkInvoices));
                }
                //1.Create Invoice and Assign Status Created
                int result = _service.CreateInvoice(model.InvoiceDate, model.DueDate, model.ProductID).Result;
                if (result > 0)
                    return RedirectToAction("ViewInvoice", new {id = result });

            }
            return RedirectToAction(nameof(BulkInvoices));
        }
        [HttpGet]
        public ActionResult ProcessInvoice(int id)
        {
            var invoice = _service.GetClientDeductionSchedule(id);
            if (UtilityService.IsNull(invoice))
                return RedirectToAction(nameof(BulkInvoices));
            var clients = _ClientService.GetClientsOnProduct(invoice.ProductID ?? 0, invoice.InvoiceDate);
            return View(clients);
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
            var deductions = _service.GetSchedule(model.DateFrom, model.DateTo);
            return View(deductions);

        }
        [HttpGet]
        public IActionResult InvoiceDetails(int id)
        {
            HttpContext.Session.SetString("ClientDeductionID", id.ToString());
            var deductions = _service.GetSchedule(id);
            deductions.InvoiceTitle = $"Deduction Schedule Invoice Number - {id.ToString()}";
            return View(deductions);
        }
        [HttpPost]
        public ActionResult DeleteInvoiceEntries(IFormCollection formCollection)
        {
            var clientDeductionIDs = formCollection["ClientDeductionDetailID"];
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
                        clientDeductionID = Convert.ToInt32(HttpContext.Session.GetString("ClientDeductionID"));
                    }
                    catch (Exception ex)
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
            ClientDeduction deduction = _service.GetClientDeductionSchedule(id);
            if(UtilityService.IsNull(deduction))
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
            int result = _service.RemoveInvoice(id).Result;
            return RedirectToAction(nameof(Invoices));
        }

        [HttpPost]
        public ActionResult GenerateSchedule(IFormCollection formCollection)
        {
            DateTime InvoiceDate = DateTime.MinValue;
            DateTime DueDate = DateTime.MinValue;
            try
            {
                InvoiceDate = Convert.ToDateTime(HttpContext.Session.GetString("InvoiceDate"));
            }
            catch (Exception ex)
            {
            }
            try
            {
                DueDate = Convert.ToDateTime(HttpContext.Session.GetString("DueDate"));
            }
            catch (Exception ex)
            {
            }
           

            var clientProductIDs = formCollection["ClientProductID"];
            List<int> clientProductID = new List<int>();
            foreach (string id in clientProductIDs)
            {
                clientProductID.Add(int.Parse(id));
            }
            if (clientProductID.Count() > 0)
            {
                int deductionID = _service.CalculateDeductions(clientProductID, 0).Result;
                if (deductionID > 0)
                {
                    HttpContext.Session.SetString("ClientDeductionID", deductionID.ToString());
                    var deductions = _service.GetClientDeductions(clientProductID, InvoiceDate).Result;
                    return View(deductions);
                }
            }
            return RedirectToAction(nameof(BulkInvoices));
        }

        [HttpGet]
        public ActionResult PrintSchedule(int id)
        {
            if (id == 0)
            {
                try
                {
                    id = Convert.ToInt32(HttpContext.Session.GetString("ClientDeductionID"));
                }
                catch (Exception ex)
                {
                }
            }
            Company company = _settingService.FindDefaultCompany();
            ClientDeduction clientDeduction = _service.GetClientDeductionSchedule(id);
            InvoiceSchedule printOut = new InvoiceSchedule();
            using (MemoryStream stream = new MemoryStream())
            {
                Document document = printOut.Print(company, clientDeduction);
                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                pdfRenderer.Document = document;
                pdfRenderer.RenderDocument();
                pdfRenderer.PdfDocument.Save(stream, false);
                return File(stream.ToArray(), "application/pdf", $"SalarySchedule.pdf");
            }
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
            var ClientList = _ClientService.Clients().Result.Select(t => new
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
        }

        //Action result for ajax call
        [HttpPost]
        public ActionResult GetProductByClientID(int clientID)
        {
            SelectList clientProducts = null;
            if (clientID != 0)
            {
                List<Product> clientproductList = _ClientService.GetClientRegisteredProducts(clientID);

                clientproductList.Select(t => new
                {
                    t.ProductID,
                    t.Name,
                }).OrderBy(t => t.Name);
                clientProducts = new SelectList(clientproductList, "ProductID", "Name");

            }
            return Json(clientProducts);
        }
        [HttpPost]
        public ActionResult GetAssertByProductID(int productID)
        {
            SelectList assertLists = null;
            if (productID != 0)
            {
                List<Assert> assertList = _settingService.GetAssertsLinkedToProduct(productID);
                assertList.Select(t => new
                {
                    t.AssertID,
                    t.Name,
                });
                assertLists = new SelectList(assertList, "AssertID", "Name");
            }
            return Json(assertLists);
        }

        [HttpPost]
        public ActionResult GetCategoryByAssertID(int assertID)
        {
            SelectList categoryList = null;
            if (assertID != 0)
            {
                List<AssertCategory> assertCategories = _settingService.GetAssertCategory(assertID);
                assertCategories.Select(t => new
                {
                    t.AssertCategoryID,
                    Name = t.Name,
                }).OrderBy(t => t.Name);
                categoryList = new SelectList(assertCategories, "AssertCategoryID", "Name");
            }
            return Json(categoryList);
        }
    }
}
