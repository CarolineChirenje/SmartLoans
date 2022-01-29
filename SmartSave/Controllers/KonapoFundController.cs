using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SmartDomain;
using SmartHelper;
using SmartInterfaces;
using SmartLogic;
using SmartExtensions;
using SmartReporting;
using System.IO;
using MigraDocCore.DocumentObjectModel;
using MigraDocCore.Rendering;
using SmartLog;
using PdfSharpCore.Pdf.IO;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf.Security;

namespace SmartSave.Controllers
{
    public class KonapoFundController : BaseController<KonapoFundController>
    {
        private readonly IKonapoFundService _service;
        private readonly IClientService _clientservice;
        private readonly ISettingService _settingService;
        public KonapoFundController(IKonapoFundService service, IClientService clientService, ISettingService settingService)
        {
            _service = service;
            _clientservice = clientService;
            _settingService = settingService;

        }
        public ActionResult KonapoFunds(string refNum = null, bool newfundsOnly = false, int id = 0)
        {
            try
            {
                if (UtilityService.UserType == (int)TypeOfUser.Employee)
                    return RedirectToAction("Dashboard", "Home");
                if (id > 0)
                {
                    Permissions permission = Permissions.View_Konapo_Fund;
                    if (!UtilityService.HasPermission(permission))
                        return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });
                    List<KonapoFund> funds = _service.GetClientKonapoFunds(id).Result;
                    return View(funds);
                }
                else
                {
                    List<KonapoFund> funds = _service.GetKonapoFunds(refNum, newfundsOnly).Result;
                    Permissions permission = Permissions.View_Konapo_Fund;
                    if (!UtilityService.HasPermission(permission))
                        return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

                    //if (UtilityService.IsNotNull(funds) && funds.Count == 1)
                    //    return RedirectToAction("ViewKonapoFund", new { id = Convert.ToInt32(funds.FirstOrDefault().KonapoFundID) });

                    return View(funds);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }


        }


        public IActionResult AddKonapoFund(int id = 0)
        {
            if (id > 0)
                HttpContext.Session.SetString("ClientID", id.ToString());
            PopulateDropDownList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddKonapoFund(KonapoFund KonapoFund)
        {

            if (ModelState.IsValid)
            {
                if (await _service.IsDuplicate(KonapoFund))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Fund Item a Fund Item  with the same Name Already Exists";
                    return View(KonapoFund);
                }
                int KonapoFundID = await (_service.Save(KonapoFund));
                if (KonapoFundID > 0)
                    return RedirectToAction("ViewKonapoFund", new { id = KonapoFundID });

            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("KonapoFunds", "Client", new { id = KonapoFund.ClientID });
        }
        // GET:
        public async Task<IActionResult> ViewKonapoFund(int id = 0)
        {

            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));
            HttpContext.Session.SetString("KonapoFundID", id.ToString());
            //var fund = await _service.GetKonapoFund(id);
            //return View(fund);
            var fund = await _service.GetKonapoFundCalculation(id);
            return View(fund);
        }
        [HttpPost]
        public JsonResult FundSearch(string prefix)
        {
            var funds = _service.GetFunds(prefix);
            return Json(funds);
        }

        [HttpPost]
        public async Task<IActionResult> ViewKonapoFund(ClientKonapoFundCalculation clientKonapoFundCalculation)
        {

            KonapoFund update = await (_service.FindKonapoFund(clientKonapoFundCalculation.KonapoFundID));
            if (UtilityService.IsNotNull(update))
            {
                KonapoFund kfund = new KonapoFund
                {
                    KonapoFundID = clientKonapoFundCalculation.KonapoFundID,
                    IsActive = clientKonapoFundCalculation.IsActive
                };
                if (await (_service.Update(kfund)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            }
            return RedirectToAction("ViewKonapoFund", new { id = clientKonapoFundCalculation.KonapoFundID });
        }
        public async Task<IActionResult> ViewKopanoFundCategory(int id)
        {
            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));
            var fund = await _service.GetKonapoFundCategory(id);
            return View(fund);
        }
        public async Task<IActionResult> ViewKonapoFundItem(int id)
        {
            if (id == 0)
                return RedirectToAction(nameof(KonapoFunds));
            PopulateDropDownList();
            var fund = await _service.FindKonapoFundCTI(id);
            return View(fund);
        }


        [HttpPost]
        public async Task<IActionResult> ViewKonapoFundItem(KonapoFundCTI KonapoFund)
        {
            Decimal ProjectedCost = UtilityService.GetDecimalAmount(KonapoFund.ProjectedCostAmount);
            Decimal Amount = UtilityService.GetDecimalAmount(KonapoFund.AmountProvided);
            KonapoFund.KonapoAmount = Amount;
            KonapoFund.ProjectedCost = ProjectedCost;
            if (ModelState.IsValid)
            {
                PopulateDropDownList();
                KonapoFundCTI update = await (_service.FindKonapoFundCTI(KonapoFund.KonapoFundCTIID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(KonapoFund)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewKopanoFundCategory", new { id = KonapoFund.KonapoFundCTID });
                }
                return View(KonapoFund);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewKopanoFundCategory", new { id = KonapoFund.KonapoFundCTID });

        }
        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteKonapoFund(id)) > 0)
                return RedirectToAction(nameof(KonapoFunds));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewKonapoFund", new { id });
            }

        }

        [HttpPost]
        public JsonResult GetKhonapoReport([FromBody] KhonapoReport report)
        {
            try
            {
                if (report != null)
                {
                    int KonapoFundID = report.KonapoFundID.ToInt();
                    if (KonapoFundID > 0)
                    {
                        int clientID = report.ClientID.ToInt();
                        if (clientID > 0)
                            report.Client = _clientservice.FindClient(clientID).Result;
                        report.Transactions = Reports.MonthlyBreakdown(KonapoFundID);

                        string filename = report.FundReference;
                        KonapoFundReport khonapoFundReport = new SmartDomain.KonapoFundReport()
                        {
                            JsonData = report.SerializetoJSON().ToString(),
                            KonapoFundID = KonapoFundID,
                            FileName = filename
                        };
                        int khonapoReportID = 0;
                        if (report.SavePrintedReport)
                            khonapoReportID = _service.Save(khonapoFundReport).Result;
                        if (khonapoReportID > 0 || !report.SavePrintedReport)
                        {
                            report.KonapoFundReportID = khonapoReportID.ToString();
                            byte[] pdfFile = GenerateKhonapoReport(report);
                            if (pdfFile != null)
                            {
                                if (report.SavePrintedReport)
                                {
                                    khonapoFundReport.Report = pdfFile;
                                    _service.Update(khonapoFundReport);
                                }
                                return Json(new { filename = filename + ".pdf", fileContents = Convert.ToBase64String(pdfFile) });
                            }
                            else
                                return Json(null);
                        }
                        else
                            return Json(null);
                    }
                    return Json(null);
                }
                else
                    return Json("The report was empty");

            }
            catch (Exception ex)
            {

                return Json(null);
            }

        }
        [OverrideUserNotFoundFilter]
        public ActionResult ReprintKhonapoReport(int id)
        {
            try
            {
                if (id > 0)
                {

                    KonapoFundReport report = _service.FindKonapoReport(id).Result;
                    if (UtilityService.IsNotNull(report))
                    {
                        string filename = report.FileName;
                        byte[] pdfFile = report.Report;
                        if (pdfFile != null)
                            return File(pdfFile, "application/pdf", filename + ".pdf");
                        else
                            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    }
                    return RedirectToAction("LogOut", "Login");

                }
                return RedirectToAction("LogOut", "Login");

            }
            catch (Exception ex)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(KonapoFunds));
            }

        }

        [OverrideUserNotFoundFilter]
        public ActionResult Verify(int id)
        {
            var report = _service.FindKonapoReport(id).Result;
            KhonapoReportVerification result = new KhonapoReportVerification();
            if (report != null)
            {
                result.KhonapoReportID = report.KonapoFundReportID;
                result.KonapoFundID = report.KonapoFundID;
                result.Verified = true;
                result.PrintDate = UtilityService.ShowDateTime(report.LastChangedDate);
            }
            return View(result);
        }
        private byte[] GenerateKhonapoReport(KhonapoReport statement)
        {
            byte[] pdffile = null;
            KhonapoFundReport printOut = new KhonapoFundReport();
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
                    byte[] finalDocument = ProcessPDF(stream.ToArray(), statement.Client.IDNumber.Trim());
                    pdffile = finalDocument;
                }
                catch (Exception ex)
                {

                    CustomLog.Log(LogSource.GUI, ex);
                }

            }
            return pdffile;
        }
        private byte[] ProcessPDF(byte[] documentGenerated, string IDNumber, bool isEmail = false)
        {
            MemoryStream stream = new MemoryStream(0);
            stream.Write(documentGenerated, 0, documentGenerated.Length);
            var document = PdfReader.Open(stream, UtilityService.StatementPasswordForAdmin.Trim(), PdfDocumentOpenMode.Modify);

            if (UtilityService.SiteEnvironment != SiteEnvironment.Production)
            {
                const int emSize = 100;
                string watermark = $"{UtilityService.SiteEnvironment}";
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

        private void PopulateDropDownList()
        {
            int clientID = 0;
            try
            {
                clientID = Convert.ToInt32(HttpContext.Session.GetString("ClientID"));
            }
            catch (Exception)
            {
                clientID = 0;
            }
            var ClientList = _clientservice.Clients().Select(t => new
            {
                t.ClientID,
                Name = $" {t.ClientFullName} - {t.AccountNumber}",
            }).OrderBy(t => t.Name);
            ViewBag.ClientList = new SelectList(ClientList, "ClientID", "Name", clientID);

            var fundSourceList = _settingService.GetActiveFundSource().Select(t => new
            {
                t.FundSourceID,
                t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.FundSourceList = new SelectList(fundSourceList, "FundSourceID", "Name");

        }
    }
}