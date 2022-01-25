using MigraDocCore.DocumentObjectModel;
using MigraDocCore.DocumentObjectModel.Shapes;
using MigraDocCore.DocumentObjectModel.Tables;
using SmartExtensions;
using SmartHelper;
using SmartInterfaces;
using SmartLog;
using System;
using System.Data;
using System.Globalization;
using System.Linq;

namespace SmartReporting
{
    public class KhonapoFundReport
    {
        // http://pdfsharp.net/wiki/HelloMigraDoc-sample.ashx
        Document document;
        Table table;
        Color TableColor = Colors.LightGray;
        Color TableBorder = Colors.Black;
        Color WhiteColor = Colors.White;
        Color HeaderColor = Colors.LightGray;
        TextFrame addressFrame;
        KhonapoReport _statement;
        CultureInfo culture;
        Section section;
        Style style;
        public Document Print(KhonapoReport statement)
        {
            try
            {
                // Create a new MigraDoc document
                this.document = new Document();
                this.document = ReportingUtilities.DocumentMetaData(this.document, "Statement of Account");
                this._statement = statement;
                // this.document.DefaultPageSetup.Orientation = Orientation.Landscape;
                this.culture = new CultureInfo("en-US");
                style = ReportingUtilities.DefineStyles(this.document);
                AddressAndHeader();
                AccountDetails();
                TransactionDetails();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
            return this.document;
        }

        void AddressAndHeader()
        {
            try
            {
                // Each MigraDoc document needs at least one section.
                section = this.document.AddSection();
                section = ReportingUtilities.SetMargins(section);
                Image image = ReportingUtilities.PrintHeaderLogo(section);
                // Create footer
                Paragraph paragraph = ReportingUtilities.PrintFooter(section);
                // Create the text frame for the address
                this.addressFrame = section.AddTextFrame();
                this.addressFrame.Height = "3.0cm";
                this.addressFrame.Width = "7.0cm";
                this.addressFrame.Left = ShapePosition.Left;
                this.addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
                this.addressFrame.Top = "5.0cm";
                this.addressFrame.RelativeVertical = RelativeVertical.Page;

                string title = "STATEMENT OF ACCOUNT";
                // Add the print date field
                PrintSubTitles($"{title}", ParagraphAlignment.Center, false, false);
                // Create the item table
                this.table = section.AddTable();
                this.table.Style = "Table";
                this.table.Borders.Width = 0;
                this.table.Borders.Left.Width = 0;
                this.table.Borders.Right.Width = 0;
                this.table.Rows.LeftIndent = 0;
                // Before you can add a row, you must define the columns
                Column column = this.table.AddColumn("10cm");
                column.Format.Alignment = ParagraphAlignment.Left;
                paragraph = this.addressFrame.AddParagraph();

                // Each item fills two rows
                Row tblrow = this.table.AddRow();
                tblrow.TopPadding = 1.5;
                tblrow.Cells[0].Borders.Visible = false;
                tblrow.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[0].Format.Font.Bold = true;
                tblrow.Cells[0].AddParagraph(_statement.Client.ClientFullName);

                Row tblrow1 = this.table.AddRow();
                tblrow1.Borders.Visible = false;
                tblrow1.TopPadding = 1.5;
                tblrow1.Cells[0].Borders.Visible = false;
                tblrow1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[0].Format.Font.Bold = true;
                tblrow1.Cells[0].AddParagraph($"{_statement.Client.AccountNumber}/{_statement.FundReference}");

                if (!String.IsNullOrEmpty(_statement.Client.AddressLine1))
                {
                    Row tblrow2 = this.table.AddRow();
                    tblrow2.Borders.Visible = false;
                    tblrow2.TopPadding = 1.5;
                    tblrow2.Cells[0].Borders.Visible = false;
                    tblrow2.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow2.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow2.Cells[0].AddParagraph(_statement.Client.AddressLine1);
                }
                if (!String.IsNullOrEmpty(_statement.Client.AddressLine2))
                {
                    Row tblrow3 = this.table.AddRow();
                    tblrow3.Borders.Visible = false;
                    tblrow3.TopPadding = 1.5;
                    tblrow3.Cells[0].Borders.Visible = false;
                    tblrow3.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow3.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow3.Cells[0].AddParagraph(_statement.Client.AddressLine2);
                }
                if (!String.IsNullOrEmpty(_statement.Client.City))
                {
                    Row tblrow4 = this.table.AddRow();
                    tblrow4.Borders.Visible = false;
                    tblrow4.TopPadding = 1.5;
                    tblrow4.Cells[0].Borders.Visible = false;
                    tblrow4.Cells[0].Format.Font.Bold = false;
                    tblrow4.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow4.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow4.Cells[0].AddParagraph(_statement.Client.City);
                }

                if (!String.IsNullOrEmpty(_statement.Client.Country))
                {
                    Row tblrow5 = this.table.AddRow();
                    tblrow5.Borders.Visible = false;
                    tblrow5.TopPadding = 1.5;
                    tblrow5.Cells[0].Borders.Visible = false;
                    tblrow5.Cells[0].Format.Font.Bold = false;
                    tblrow5.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow5.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow5.Cells[0].AddParagraph(_statement.Client.Country);
                }

                if (!String.IsNullOrEmpty(_statement.Client.MobileNumber))
                {
                    Row tblrow6 = this.table.AddRow();
                    tblrow6.Borders.Visible = false;
                    tblrow6.TopPadding = 1.5;
                    tblrow6.Cells[0].Borders.Visible = false;
                    tblrow6.Cells[0].Format.Font.Bold = false;
                    tblrow6.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow6.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow6.Cells[0].AddParagraph($"{_statement.Client.MobileNumber}");
                }

                if (!String.IsNullOrEmpty(_statement.Client.EmailAddress))
                {
                    Row tblrow7 = this.table.AddRow();
                    tblrow7.Borders.Visible = false;
                    tblrow7.TopPadding = 1.5;
                    tblrow7.Cells[0].Borders.Visible = false;
                    tblrow7.Cells[0].Format.Font.Bold = false;
                    tblrow7.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow7.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow7.Cells[0].AddParagraph($"{_statement.Client.EmailAddress}");
                }

                paragraph = section.AddParagraph();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        void AccountDetails()
        {
            try
            {

                string columnName = String.Empty;
                string columnValue = String.Empty;
                columnName = "Fund";
                columnValue = String.IsNullOrEmpty(_statement.FundName) ? "Unknown" : _statement.FundName;
                // Create the item table
                this.table = section.AddTable();
                this.table.Style = "Table";
                this.table.Borders.Width = 0;
                this.table.Borders.Left.Width = 0;
                this.table.Borders.Right.Width = 0;
                this.table.Rows.LeftIndent = 0;

                // Before you can add a row, you must define the columns
                Column column = this.table.AddColumn("3cm");
                column.Format.Alignment = ParagraphAlignment.Left;

                column = this.table.AddColumn("5cm");
                column.Format.Alignment = ParagraphAlignment.Left;

                column = this.table.AddColumn("3cm");
                column.Format.Alignment = ParagraphAlignment.Left;

                column = this.table.AddColumn("5cm");
                column.Format.Alignment = ParagraphAlignment.Left;

                Paragraph paragraph = this.addressFrame.AddParagraph();
                // Each item fills two rows
                Row tblrow = this.table.AddRow();

                tblrow.TopPadding = 1.5;
                tblrow.Cells[0].Borders.Visible = false;
                tblrow.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[0].Format.Font.Bold = true;
                tblrow.Cells[0].AddParagraph(columnName);

                tblrow.Cells[1].Borders.Visible = false;
                tblrow.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[1].AddParagraph(columnValue);

                Row tblrow1 = this.table.AddRow();
                tblrow1.Borders.Visible = false;
                tblrow1.TopPadding = 1.5;
                tblrow1.Cells[0].Borders.Visible = false;
                tblrow1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[0].Format.Font.Bold = true;
                tblrow1.Cells[0].AddParagraph("Print Date");

                tblrow1.Cells[1].Borders.Visible = false;
                tblrow1.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[1].AddParagraph(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                paragraph = section.AddParagraph();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }
        void TransactionDetails()
        {

            PrintCalculationForm();
            PrintSubTitles($"{_statement.FundName}  Projections and Breakdown".ToUpper(), ParagraphAlignment.Left, true, false);
            //Target : TimeRequired
            PrintTargetTimeRequired();
            //Target : AccountingForProgress
            PrintTargetAccountForProgress();
            //Target : TargetAnnual
            PrintTargetAnnualTarget();
            //Compound Interest : Regular Deposits
            PrintCIRD();
            //Compound Interest : OTI
            PrintCIOTI();
            //MonthlyBreakDown
            PrintMonthlyBreakdown();

        }

        void PrintCalculationForm()
        {
            try
            {
                PrintSubTitles($"{_statement.FundName} Calculation".ToUpper(), ParagraphAlignment.Center);
                Paragraph paragraph = this.addressFrame.AddParagraph();
                Column column = DefineTableAndColumns();
                PrintFormValues("Khonapo Fund", _statement.CFFund);
                PrintFormValues("Minimum Survival Period (Months)", _statement.CFPeriod);
                PrintFormValues("Emergency Fund", _statement.CFEmergencyfund);
                PrintFormValues($"Annual {_statement.FundName}", _statement.CFAnnualFund);
                PrintFormValues("Retirement LifeTime (Years)", _statement.CFRetirementPeriod);
                PrintFormValues($"{_statement.FundName} (LifeTime)", _statement.CFLifeTimeRetirement);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        void PrintTargetTimeRequired()
        {
            try
            {
                PrintSubTitles($"Time Required (How long will it take me/us to reach the target)");
                Paragraph paragraph = null;
                Column column = DefineTableAndColumns();
                paragraph = this.addressFrame.AddParagraph();
                PrintFormValues("Monthly Income (Average)", _statement.TTRIncomeAverage);
                PrintFormValues("Monthly Committment", _statement.TTRCommittment);
                PrintFormValues("Emergency Fund Target (Months)", _statement.TTRFundTargetMonths);
                PrintFormValues($"Emergency Fund Target (Years)", _statement.TTRFundTargetYears);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        void PrintTargetAccountForProgress()
        {
            try
            {
                PrintSubTitles($"Time to Reach Emergency Fund (Accounting for Progress)");
                Paragraph paragraph = null;
                Column column = DefineTableAndColumns();
                paragraph = this.addressFrame.AddParagraph();
                PrintFormValues("Progress Made", _statement.TAFPProgress);
                PrintFormValues("Balance To Target", _statement.TAFPBalance);
                PrintFormValues("Monthly Commitment", _statement.TAFPCommittment);
                PrintFormValues("Time To Reach Target ( Months )", _statement.TAFPTargetMonths);
                PrintFormValues("Time To Reach Target ( Years )", _statement.TAFPTargetYears);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        void PrintTargetAnnualTarget()
        {
            try
            {
                PrintSubTitles($"Time to Reach Annual {_statement.FundName} Target");
                Paragraph paragraph = null;
                Column column = DefineTableAndColumns();
                paragraph = this.addressFrame.AddParagraph();
                PrintFormValues("Progress Made", _statement.TATCommittment);
                PrintFormValues("Balance To Target", _statement.TATBalance);
                PrintFormValues("Monthly Commitment", _statement.TATCommittment);
                PrintFormValues("Time To Reach Target ( Months )", _statement.TATTargetMonths);
                PrintFormValues("Time To Reach Target ( Years )", _statement.TATTargetYears);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        void PrintCIOTI()
        {
            try
            {
                PrintSubTitles($"One Time Investment : Compound Growth Calculations");
                Paragraph paragraph = null;
                Column column = DefineTableAndColumns();
                paragraph = this.addressFrame.AddParagraph();
                PrintFormValues("Investment Amount", _statement.OTIInvestmentAmount);
                PrintFormValues("Interest Rate", _statement.OTIInterestRate);
                PrintFormValues("Tenure", _statement.OTITenure);
                PrintFormValues(GetTenureLable(_statement.OTITenure), _statement.OTITotalValue);
                PrintFormValues("Multiplier", _statement.OTIMultiplier);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        void PrintCIRD()
        {
            try
            {
                PrintSubTitles($"Regular Deposits : Compound Growth Calculations");
                Paragraph paragraph = null;
                Column column = DefineTableAndColumns();
                paragraph = this.addressFrame.AddParagraph();
                PrintFormValues($"Initial Amount Available To Invest in {_statement.FundName}", _statement.RDInvestmentAmount);
                PrintFormValues("Interest Rate / Rate of Return", _statement.RDInterestRate);
                PrintFormValues("Tenure / Number of Years", _statement.RDTenure);
                PrintFormValues("Number of Payments / Contributions in a Year", _statement.RDPaymentsYear);
                PrintFormValues("Monthly Contributions", _statement.RDContributions);
                PrintFormValues(GetTenureLable(_statement.RDTenure), _statement.RDTotalValue);
                PrintFormValues("Multiplier", _statement.RDMultiplier);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }
        void PrintMonthlyBreakdown()
        {
            try
            {
                PrintSubTitles($"Monthly: Breakdown of {_statement.FundName} by Amount and Percentage");
                Paragraph paragraph = null;
                DataTable Transactions = Reports.MonthlyBreakdown(_statement.KonapoFundID.ToInt());

                if (Transactions != null && Transactions.Rows.Count > 0)
                {
                    // Create the item table
                    this.table = section.AddTable();
                    this.table.Style = "Table";
                    this.table.Borders.Color = TableBorder;
                    if (UtilityService.StatementShowTableBoarders)
                    {
                        this.table.Borders.Width = 0.25;
                        this.table.Borders.Left.Width = 0.25;
                        this.table.Borders.Right.Width = 0.25;

                    }

                    else
                    {

                        this.table.Borders.Width = 0;
                        this.table.Borders.Left.Width = 0;
                        this.table.Borders.Right.Width = 0;
                        this.table.Rows.LeftIndent = 0;
                    }

                    // Before you can add a row, you must define the columns
                    Column column = this.table.AddColumn("8.3cm");
                    column.Format.Alignment = ParagraphAlignment.Left;

                    column = this.table.AddColumn("5cm");
                    column.Format.Alignment = ParagraphAlignment.Right;

                    column = this.table.AddColumn("3cm");
                    column.Format.Alignment = ParagraphAlignment.Right;


                    // Create the header of the table
                    Row row = table.AddRow();
                    row.HeadingFormat = true;
                    row.Format.Alignment = ParagraphAlignment.Center;
                    row.Format.Font.Bold = true;
                    row.Shading.Color = HeaderColor;
                    int countCellColumn = 0;

                    row.Cells[countCellColumn].AddParagraph("Category");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;

                    row.Cells[countCellColumn].AddParagraph("Amount");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;

                    row.Cells[countCellColumn].AddParagraph("Percentage");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;

                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(0, 0, countCellColumn + 1, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

                    paragraph = this.addressFrame.AddParagraph();

                    int finalCountCellValue = 0;
                    foreach (DataRow transaction in Transactions.Rows)
                    {
                        int countCellValue = 0;
                        // Each item fills two rows
                        Row row1 = this.table.AddRow();

                        row1.TopPadding = 1.5;
                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Left;
                        row1.Cells[countCellValue].AddParagraph(transaction.Field<string>("Category"));
                        countCellValue++;

                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Right;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].AddParagraph(String.Format(culture, "{0:C}", transaction.Field<decimal>("TotalAmount")));
                        countCellValue++;

                        decimal _extractedValue = Math.Round(transaction.Field<decimal>("TotalAsAPercentage"), 2);
                        string Percentage = _extractedValue.ToString().Replace(",",".");
                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Right;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].AddParagraph($"{Percentage}%");
                        finalCountCellValue = countCellValue;
                        if (UtilityService.StatementShowTableBoarders)
                            this.table.SetEdge(0, this.table.Rows.Count - 1, finalCountCellValue + 1, 1, Edge.Box, BorderStyle.Single, 0.75);
                    }

                    // Add an invisible row as a space line to the table
                    Row row2 = this.table.AddRow();
                    row2.Borders.Visible = false;

                    decimal TotalAmount = Transactions.AsEnumerable().Sum(transaction => transaction.Field<decimal>("TotalAmount"));
                    decimal TotalPercentage = Transactions.AsEnumerable().Sum(transaction => transaction.Field<decimal>("TotalAsAPercentage"));
                    TotalAmount = Math.Round(TotalAmount, 2);
                    TotalPercentage = Math.Round(TotalPercentage, 2);
                    // Add the total due row
                    row2 = this.table.AddRow();
                    row2.Cells[0].Borders.Visible = false;
                    row2.Cells[0].Format.Font.Bold = true;
                    row2.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                    row2.Cells[0].MergeRight = finalCountCellValue - 2;
                    row2.Cells[0].AddParagraph("Total");
                    row2.Cells[finalCountCellValue - 1].AddParagraph(String.Format(culture, "{0:C}", TotalAmount));
                    row2.Cells[finalCountCellValue].AddParagraph($"{TotalPercentage.ToString().Replace(",",".")}%");
                    // Set the borders of the specified cell range
                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(finalCountCellValue - 1, this.table.Rows.Count - 1, 1, 1, Edge.Box, BorderStyle.Single, 0.75);
                }
                else
                {
                    try
                    {
                        paragraph = this.addressFrame.AddParagraph();
                        Column column = DefineTableAndColumns();
                        PrintFormValues("Monthly Breakdown : Not Available", String.Empty);
                    }
                    catch (Exception ex)
                    {
                        CustomLog.Log(LogSource.Reporting, ex);
                        throw;
                    }

                }

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        void PrintFormValues(string name, string value, bool formatNumbers = true)
        {
            Row tblRow = this.table.AddRow();
            tblRow.TopPadding = 1.5;
            tblRow.Cells[0].Borders.Visible = false;
            tblRow.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
            tblRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            tblRow.Cells[0].AddParagraph(name);
            tblRow.Cells[0].Format.Font.Bold = true;

            tblRow.Cells[1].Borders.Visible = false;
            tblRow.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;
            tblRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            if (formatNumbers)
            {
                string amount = String.IsNullOrEmpty(value) ? "0.00" : value;
                tblRow.Cells[1].AddParagraph(amount.ToFormattedCurrency());
            }
            else
                tblRow.Cells[1].AddParagraph(String.IsNullOrEmpty(value) ? String.Empty : value);
        }
        void PrintSubTitles(string title, ParagraphAlignment paragraphAlignment = ParagraphAlignment.Left, bool showBoarder = true, bool shadeParagraph = true)
        {
            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "0.7cm";
            paragraph.Style = StyleNames.Heading1;
            paragraph.AddFormattedText(title, TextFormat.Bold);
            paragraph.Format.Alignment = paragraphAlignment;
            if (showBoarder)
            {
                paragraph.Format.Borders.Width = 0.5;
                paragraph.Format.Borders.Color = Colors.Black;
                paragraph.Format.Borders.Distance = 3;
            }
            if (shadeParagraph)
                paragraph.Format.Shading.Color = Colors.LightGray;
            paragraph = section.AddParagraph();

        }

        Column DefineTableAndColumns()
        { // Create the item table
            this.table = section.AddTable();
            this.table.Style = "Table";
            this.table.Borders.Color = TableBorder;
            //if (UtilityService.StatementShowTableBoarders)
            //{
            //    this.table.Borders.Width = 0.25;
            //    this.table.Borders.Left.Width = 0.25;
            //    this.table.Borders.Right.Width = 0.25;
            //}
            //else
            //{
            this.table.Borders.Width = 0.25;
            this.table.Borders.Left.Width = 0.5;
            this.table.Borders.Right.Width = 0.5;
            this.table.Rows.LeftIndent = 0;
            //}

            // Before you can add a row, you must define the columns
            Column column = this.table.AddColumn("10cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = this.table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Right;
            return column;
        }

        string GetTenureLable(string value)
        {
            try
            {
              return   (String.IsNullOrEmpty(value) || value.Equals("0.00")) ? "Value After Years" : $"Value After {value} Years";

            }
            catch (Exception)
            {
                return "Value After Years";

            }
        }
    }

}

