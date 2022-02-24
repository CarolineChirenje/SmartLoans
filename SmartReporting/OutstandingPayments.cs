using MigraDocCore.DocumentObjectModel;
using MigraDocCore.DocumentObjectModel.Shapes;
using MigraDocCore.DocumentObjectModel.Tables;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartInterfaces;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace SmartReporting
{
    public class OutstandingPayments
    {
        Document document;
        Table table;
        Color TableColor = Colors.LightGray;
        Color TableBorder = Colors.Black;
        Color WhiteColor = Colors.White;
        Color HeaderColor = Colors.LightGray;
        TextFrame addressFrame;
        OutstandingStatement _statement;
        CultureInfo culture;
        Section section;
        Style style;
        public Document Print(OutstandingStatement statement)
        {
            try
            {
                // Create a new MigraDoc document
                this.document = new Document();
                this.document = ReportingUtilities.DocumentMetaData(this.document, "Statement of Account");
                this._statement = statement;
                this.culture = new CultureInfo("en-US");
                style = ReportingUtilities.DefineStyles(this.document);
                AddressAndHeader();
                PrintOutStandingPayments();
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

                string title = "OUTSTANDING PAYMENTS";
                // Add the print date field
                paragraph = section.AddParagraph();
                paragraph.Format.SpaceBefore = "0.5cm";
                paragraph.Style = StyleNames.Heading1;
                paragraph.AddFormattedText($"{title}", TextFormat.Bold);
                paragraph.Format.Alignment = ParagraphAlignment.Center;
                paragraph = section.AddParagraph();

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

                if (!String.IsNullOrEmpty(_statement.Client.AddressLine1))
                {
                    Row tblrow1 = this.table.AddRow();
                    tblrow1.Borders.Visible = false;
                    tblrow1.TopPadding = 1.5;
                    tblrow1.Cells[0].Borders.Visible = false;
                    tblrow1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow1.Cells[0].AddParagraph(_statement.Client.AddressLine1);
                }
                if (!String.IsNullOrEmpty(_statement.Client.AddressLine2))
                {
                    Row tblrow2 = this.table.AddRow();
                    tblrow2.Borders.Visible = false;
                    tblrow2.TopPadding = 1.5;
                    tblrow2.Cells[0].Borders.Visible = false;
                    tblrow2.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow2.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow2.Cells[0].AddParagraph(_statement.Client.AddressLine2);
                }
                if (!String.IsNullOrEmpty(_statement.Client.City))
                {
                    Row tblrow3 = this.table.AddRow();
                    tblrow3.Borders.Visible = false;
                    tblrow3.TopPadding = 1.5;
                    tblrow3.Cells[0].Borders.Visible = false;
                    tblrow3.Cells[0].Format.Font.Bold = false;
                    tblrow3.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow3.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow3.Cells[0].AddParagraph(_statement.Client.City);
                }
                if (_statement.Client.Country.IsNotNull())
                {

                    Row tblrow4 = this.table.AddRow();
                    tblrow4.Borders.Visible = false;
                    tblrow4.TopPadding = 1.5;
                    tblrow4.Cells[0].Borders.Visible = false;
                    tblrow4.Cells[0].Format.Font.Bold = false;
                    tblrow4.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow4.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow4.Cells[0].AddParagraph(_statement.Client.Country);

                }
                if (!String.IsNullOrEmpty(_statement.Client.MobileNumber))
                {
                    Row tblrow5 = this.table.AddRow();
                    tblrow5.Borders.Visible = false;
                    tblrow5.TopPadding = 1.5;
                    tblrow5.Cells[0].Borders.Visible = false;
                    tblrow5.Cells[0].Format.Font.Bold = false;
                    tblrow5.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow5.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow5.Cells[0].AddParagraph($"{_statement.Client.MobileNumber}");
                }

                if (!String.IsNullOrEmpty(_statement.Client.EmailAddress))
                {
                    Row tblrow6 = this.table.AddRow();
                    tblrow6.Borders.Visible = false;
                    tblrow6.TopPadding = 1.5;
                    tblrow6.Cells[0].Borders.Visible = false;
                    tblrow6.Cells[0].Format.Font.Bold = false;
                    tblrow6.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow6.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow6.Cells[0].AddParagraph($"{_statement.Client.EmailAddress}");
                }

                paragraph = section.AddParagraph();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }

        public void PrintOutStandingPayments()
        {
            try
            {
                var cutoffDate = DateTime.Now.AddMonths(1);
                _statement.StartDate = DateTime.MinValue;
                _statement.EndDate = cutoffDate;
                DataTable Transactions = Reports.OutstandingPayments(_statement);
                Paragraph paragraph = null;
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
                    Column column = this.table.AddColumn("5cm");
                    column.Format.Alignment = ParagraphAlignment.Left;

                    column = this.table.AddColumn("4cm");
                    column.Format.Alignment = ParagraphAlignment.Left;

                    column = this.table.AddColumn("3cm");
                    column.Format.Alignment = ParagraphAlignment.Left;

                    column = this.table.AddColumn("2.5cm");
                    column.Format.Alignment = ParagraphAlignment.Left;

                    column = this.table.AddColumn("2.5cm");
                    column.Format.Alignment = ParagraphAlignment.Right;

                    // Create the header of the table
                    Row row = table.AddRow();
                    row.HeadingFormat = true;
                    row.Format.Alignment = ParagraphAlignment.Center;
                    row.Format.Font.Bold = true;
                    row.Shading.Color = HeaderColor;
                    int countCellColumn = 0;

                    row.Cells[countCellColumn].AddParagraph("Entity");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;

                    row.Cells[countCellColumn].AddParagraph("Fee Name");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;

                    row.Cells[countCellColumn].AddParagraph("Payment Terms");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;
                    row.Cells[countCellColumn].AddParagraph("Due Date");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;

                    row.Cells[countCellColumn].AddParagraph("Amount");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = ParagraphAlignment.Right;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;

                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(0, 0, countCellColumn + 1, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

                    paragraph = this.addressFrame.AddParagraph();

                    int finalCountCellValue = 0;

                    foreach (DataRow transaction in Transactions.Rows)
                    {
                        int countCellValue = 0;

                        Row row1 = this.table.AddRow();

                        row1.TopPadding = 1.5;
                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Left;
                        row1.Cells[countCellValue].AddParagraph(transaction.Field<string>("Entity"));
                        countCellValue++;


                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Left : ParagraphAlignment.Center;
                        row1.Cells[countCellValue].AddParagraph(transaction.Field<string>("Fee"));
                        countCellValue++;

                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Left : ParagraphAlignment.Left;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].AddParagraph(transaction.Field<string>("PaymentTerms"));
                        countCellValue++;

                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Left : ParagraphAlignment.Center;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].AddParagraph(UtilityService.ShowDate(transaction.Field<DateTime>("DueDate")));
                        countCellValue++;


                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Right;
                        row1.Cells[countCellValue].AddParagraph(String.Format(culture, "{0:C}", transaction.Field<decimal>("Amount")));

                        finalCountCellValue = countCellValue;
                        if (UtilityService.StatementShowTableBoarders)
                            this.table.SetEdge(0, this.table.Rows.Count - 1, finalCountCellValue + 1, 1, Edge.Box, BorderStyle.Single, 0.75);

                    }



                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(0, this.table.Rows.Count - 1, finalCountCellValue + 1, 1, Edge.Box, BorderStyle.Single, 0.75);

                    // Add an invisible row as a space line to the table
                    Row row2 = this.table.AddRow();
                    row2.Borders.Visible = false;
                    decimal totalDue = Transactions.AsEnumerable().Sum(transaction => transaction.Field<decimal>("Amount"));
                    // Add the total due row
                    row2 = this.table.AddRow();
                    row2.Cells[0].Borders.Visible = false;
                    row2.Cells[0].Format.Font.Bold = true;
                    row2.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                    row2.Cells[0].MergeRight = finalCountCellValue - 1;
                    row2.Cells[0].AddParagraph("Total Due");
                    row2.Cells[finalCountCellValue].AddParagraph(String.Format(culture, "{0:C}", totalDue));

                    // Set the borders of the specified cell range
                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(finalCountCellValue, this.table.Rows.Count - 1, 1, 1, Edge.Box, BorderStyle.Single, 0.75);
                }
                else
                    paragraph = this.addressFrame.AddParagraph();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }



    }
}
