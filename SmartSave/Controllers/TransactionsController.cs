using System;
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
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace SmartSave.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ITransactionService _service;
        private readonly ISettingService _settingService;
        private readonly IClientService _ClientService;
        private readonly IBankAccountservice _bankService;
        public TransactionsController(ITransactionService service, IClientService ClientService, ISettingService settingService, IBankAccountservice bankService)
        {
            _service = service;
            _ClientService = ClientService;
            _settingService = settingService;
            _bankService = bankService;
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

                Client Client = await _ClientService.FindClient(paymentsFile.ClientID);
                if (!UtilityService.IsNotNull(Client))
                    return RedirectToAction(nameof(Transactions));
            Decimal Amount = UtilityService.GetDecimalAmount(paymentsFile.Amount);

                Transaction addPaymentsFile = new Transaction()
                {
                    Year = paymentsFile.Year,
                    Month = paymentsFile.Month,
                    Amount = Amount,
                    ClientID = Client.ClientID,
                    Client = Client,
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
                    AssertCategoryID=paymentsFile.AssertCategoryID
                    
                };

                if (await (_service.CreatePayment(addPaymentsFile, (TransactionTypeList)paymentsFile.TransactionTypeID)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
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
            if (clientID>0)
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
            //if (clientid!=0)
            //    return RedirectToAction("ViewClient", "Client", new { id = clientid });
            //else
            return RedirectToAction(nameof(Transactions));
        }

        [HttpGet]
        public async Task<ActionResult> PrintTransaction(int id)
        {
            if (id == 0)
                return RedirectToAction(nameof(Transactions));

            Transaction transaction = await _service.PaymentFile(id);
            if (UtilityService.IsNotNull(transaction))
            {

                TransactionPrintOut printOut = new TransactionPrintOut();

                using (MemoryStream stream = new MemoryStream())
                {
                    Document document = printOut.Print(transaction);
                    PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                    pdfRenderer.Document = document;
                    pdfRenderer.RenderDocument();
                    pdfRenderer.PdfDocument.Save(stream, false);
                    return File(stream.ToArray(), "application/pdf", transaction.TransRef + ".pdf");
                }
            }
            return RedirectToAction(nameof(Transactions));

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

            ViewBag.ClientList = new SelectList(ClientList, "ClientID", "Name",clientID);

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
