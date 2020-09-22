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
            return View(await _service.Transactions());
        }
       

        public IActionResult RecordPayment()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RecordPayment(PaymentViewModel paymentsFile)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
               Client Client= await  _ClientService.FindClient(0,paymentsFile.AccountNumber.Trim());
                if(!UtilityService.IsNotNull(Client))
                    return RedirectToAction(nameof(Transactions));
                Transaction addPaymentsFile = new Transaction()
                {
                    Year = paymentsFile.Year,
                    Month = paymentsFile.Month,
                    Amount = paymentsFile.Amount,
                    ClientID = Client.ClientID,
                    Client=Client,
                    ProductID = paymentsFile.ProductID,
                    PaymentDate = paymentsFile.PaymentDate,
                    PaymentStatusID = (int)PaymentState.Paid,
                    TransactionDate = DateTime.Now,
                    Discount = paymentsFile.Discount,
                    ParentPaymentID = paymentsFile.ParentPaymentID,
                    LastChangedBy = UtilityService.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                    BankAccountID=paymentsFile.BankAccountID,
                    TransactionTypeID=paymentsFile.TransactionTypeID

                };

                if (await (_service.CreatePayment(addPaymentsFile, (TransactionTypeList)paymentsFile.TransactionTypeID)) == 0)
                {
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(paymentsFile);

                }
               
            }
            if (paymentsFile.IsFromClient)
                return RedirectToAction("ViewClient", "Client", new { id = paymentsFile.ClientID });
            else
                return RedirectToAction(nameof(Transactions));
        }
        // GET:
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
                if (await (_service.CreatePayment(paymentsFile, (TransactionTypeList)transactionTypeID)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewTransaction", new { paymentsFile.TransactionID });
            }
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

            var ClientList = _ClientService.Clients().Result.Select(t => new
            {
                t.ClientID,
                Name = t.AccountNumber.ToString(),
            }).OrderBy(t => t.Name);

            ViewBag.ClientList = new SelectList(ClientList, "ClientID", "Name");

            var bankList = _bankService.Banks().Result.Select(t => new
            {
                t.BankAccountID,
                Name = t.AccountName.ToString(),
            }).OrderBy(t => t.Name);

            ViewBag.BankAccountList = new SelectList(bankList, "BankAccountID", "Name");

            var transactionTypeList = _settingService.GetActiveTransactionTypeList().Select(t => new
            {
                t.TransactionTypeID,
               Name= t.TransType,
            }).OrderBy(t => t.Name);

            ViewBag.TransactionTypeList  = new SelectList(transactionTypeList, "TransactionTypeID", "Name",(int)TransactionTypeList.Payment);

        }
    }
}
