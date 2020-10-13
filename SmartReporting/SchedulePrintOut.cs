﻿using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
namespace SmartReporting
{
    public class SchedulePrintOut
    {
        Document document;
        Table table;
        Color TableColor = Colors.LightGray;
        Color TableBorder = Colors.Black;
        Color WhiteColor = Colors.White;
        Color HeaderColor = Colors.LightGray;
        TextFrame addressFrame;
        DateTime _InvoiceDate;
        DateTime _DueDate;
        DateTime _DateFrom;
        DateTime _DateTo;
        CultureInfo culture;
        Section section;
        Style style;
        Product _Product;
        Company _Company;
        bool _PrintGeneratedSchedule = false;


        public Document Print(Product Product, Company Company, DateTime InvoiceDate, DateTime DueDate)
        {
            try
            {

                // Create a new MigraDoc document
                this.document = new Document();
                this.document = ReportingUtilities.DocumentMetaData(this.document, "Salary Schedule");
                this._Product = Product;
                this._Company = Company;
                this._InvoiceDate = InvoiceDate;
                this._DueDate = DueDate;
                this.culture = new CultureInfo("en-US");
                style = ReportingUtilities.DefineStyles(this.document);
                AddressAndHeader();
                ProductDetails();
                ScheduleDetails();


            }
            catch (Exception e)
            {

                //  ErrorLog.Log(e, ErrorSource.Reporting);
            }
            return this.document;
        }


        public Document PrintGeneratedSchedule(Product Product, Company Company, DateTime DateFrom, DateTime DateTo)
        {
            try
            {

                // Create a new MigraDoc document
                this.document = new Document();
                this.document = ReportingUtilities.DocumentMetaData(this.document, "Salary Schedule");
                this._Product = Product;
                this._Company = Company;
                this._DateFrom = DateFrom;
                this._DateTo = DateTo;
                this.culture = new CultureInfo("en-US");
                style = ReportingUtilities.DefineStyles(this.document);
                _PrintGeneratedSchedule = true;
                AddressAndHeader();
                ProductDetails();
                ScheduleDetails();


            }
            catch (Exception e)
            {

                //  ErrorLog.Log(e, ErrorSource.Reporting);
            }
            return this.document;
        }
        void AddressAndHeader()
        {
            try
            {
                // Each MigraDoc document needs at least one section.
                section = this.document.AddSection();
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



                string title = "SALARY SCHEDULE";

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

                if (UtilityService.IsNull(_Company))
                {
                    // Each item fills two rows
                    Row tblrow = this.table.AddRow();

                    tblrow.TopPadding = 1.5;
                    tblrow.Cells[0].Borders.Visible = false;
                    tblrow.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    tblrow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    tblrow.Cells[0].Format.Font.Bold = true;
                    tblrow.Cells[0].AddParagraph(_Company.Name);

                    if (!String.IsNullOrEmpty(_Company.AddressLine1))
                    {
                        Row tblrow1 = this.table.AddRow();
                        tblrow1.Borders.Visible = false;
                        tblrow1.TopPadding = 1.5;
                        tblrow1.Cells[0].Borders.Visible = false;
                        tblrow1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                        tblrow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                        tblrow1.Cells[0].AddParagraph(_Company.AddressLine1);

                    }
                    if (!String.IsNullOrEmpty(_Company.AddressLine2))
                    {
                        Row tblrow2 = this.table.AddRow();
                        tblrow2.Borders.Visible = false;
                        tblrow2.TopPadding = 1.5;
                        tblrow2.Cells[0].Borders.Visible = false;
                        tblrow2.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                        tblrow2.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                        tblrow2.Cells[0].AddParagraph(_Company.AddressLine2);
                    }
                    if (!String.IsNullOrEmpty(_Company.City))
                    {
                        Row tblrow3 = this.table.AddRow();
                        tblrow3.Borders.Visible = false;
                        tblrow3.TopPadding = 1.5;
                        tblrow3.Cells[0].Borders.Visible = false;
                        tblrow3.Cells[0].Format.Font.Bold = true;
                        tblrow3.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                        tblrow3.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                        tblrow3.Cells[0].AddParagraph(_Company.City);
                    }
                    if (!String.IsNullOrEmpty(_Company.Country.Name))
                    {
                        Row tblrow4 = this.table.AddRow();
                        tblrow4.Borders.Visible = false;
                        tblrow4.TopPadding = 1.5;
                        tblrow4.Cells[0].Borders.Visible = false;
                        tblrow4.Cells[0].Format.Font.Bold = true;
                        tblrow4.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                        tblrow4.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                        tblrow4.Cells[0].AddParagraph(_Company.Country.Name);
                    }

                    if (!String.IsNullOrEmpty(_Company.Phone))
                    {
                        Row tblrow5 = this.table.AddRow();
                        tblrow5.Borders.Visible = false;
                        tblrow5.TopPadding = 1.5;
                        tblrow5.Cells[0].Borders.Visible = false;
                        tblrow5.Cells[0].Format.Font.Bold = true;
                        tblrow5.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                        tblrow5.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                        tblrow5.Cells[0].AddParagraph($"Phone : {_Company.Phone}");
                    }

                    if (!String.IsNullOrEmpty(_Company.Mobile))
                    {
                        Row tblrow6 = this.table.AddRow();
                        tblrow6.Borders.Visible = false;
                        tblrow6.TopPadding = 1.5;
                        tblrow6.Cells[0].Borders.Visible = false;
                        tblrow6.Cells[0].Format.Font.Bold = true;
                        tblrow6.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                        tblrow6.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                        tblrow6.Cells[0].AddParagraph($"Mobile : {_Company.Mobile}");
                    }

                    if (!String.IsNullOrEmpty(_Company.Website))
                    {
                        Row tblrow7 = this.table.AddRow();
                        tblrow7.Borders.Visible = false;
                        tblrow7.TopPadding = 1.5;
                        tblrow7.Cells[0].Borders.Visible = false;
                        tblrow7.Cells[0].Format.Font.Bold = true;
                        tblrow7.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                        tblrow7.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                        tblrow7.Cells[0].AddParagraph($"{_Company.Website}");
                    }
                    paragraph = section.AddParagraph();
                }
            }

            catch (Exception e)
            {
                throw e;
                //   ErrorLog.Log(e, ErrorSource.Reporting);
            }
        }

        void ProductDetails()
        {
            try
            {
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
                tblrow.Cells[0].AddParagraph("Product");

                tblrow.Cells[1].Borders.Visible = false;
                tblrow.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[1].AddParagraph(UtilityService.IsNull(_Product) ? " - " : _Product.Name);

                string column2Name = _PrintGeneratedSchedule ? "Period" : "Cut Off Date";
                tblrow.Cells[2].Borders.Visible = false;
                tblrow.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[2].Format.Font.Bold = true;
                tblrow.Cells[2].AddParagraph(column2Name);

                string column2Value = _PrintGeneratedSchedule ? $"{UtilityService.ShowDate(_DateFrom)} => {UtilityService.ShowDate(_DateTo)}" : UtilityService.ShowDate(_InvoiceDate);
                tblrow.Cells[3].Borders.Visible = false;
                tblrow.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[3].AddParagraph(column2Value);

                Row tblrow1 = this.table.AddRow();
                tblrow1.Borders.Visible = false;
                tblrow1.TopPadding = 1.5;
                tblrow1.Cells[0].Borders.Visible = false;
                tblrow1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[0].Format.Font.Bold = true;
                tblrow1.Cells[0].AddParagraph("Printed By");

                tblrow1.Cells[1].Borders.Visible = false;
                tblrow1.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[1].AddParagraph(UtilityService.UserFullName);

                tblrow1.Cells[2].Borders.Visible = false;
                tblrow1.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[2].Format.Font.Bold = true;
                tblrow1.Cells[2].AddParagraph("Print Date");

                tblrow1.Cells[3].Borders.Visible = false;
                tblrow1.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[3].AddParagraph(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));


                paragraph = section.AddParagraph();
            }

            catch (Exception e)
            {

                //  ErrorLog.Log(e, ErrorSource.Reporting);
            }
        }
        void ScheduleDetails()
        {

            try
            {
                string sqlQuery;
                string _selectClause = @"SELECT CONCAT(c.AccountNumber,' - ',c.LastName,' ', c.FirstName) AS ClientName, cd.InvoiceNumber, p.Name AS Product,cd.DeductedAmount AS AmountDue, cd.DueDate,cd.InvoiceDate, c.Occupation FROM ClientDeductions cd
                                            INNER JOIN Clients c ON cd.ClientID=c.ClientID
                                            INNER JOIN Products p ON p.ProductID=cd.ProductID ";
                if (_PrintGeneratedSchedule)
                {
                    sqlQuery = _selectClause + $"WHERE  cd.InvoiceDate>='{_DateFrom.ToString("yyyy-MM-dd")}' AND cd.InvoiceDate<='{_DateTo.ToString("yyyy-MM-dd")}' ";
                }
                else
                {
                    sqlQuery = _selectClause + $"WHERE  cd.InvoiceDate='{_InvoiceDate.ToString("yyyy-MM-dd")}'";
                }

                if (_Product.ProductID > 0)
                    sqlQuery = sqlQuery + $" AND cd.ProductID={_Product.ProductID}";


                sqlQuery = sqlQuery + $" ORDER BY cd.InvoiceNumber,CONCAT(c.AccountNumber,' - ',c.LastName,' ', c.FirstName)";

                DataTable Transactions = GetData.GetDataTable(sqlQuery);



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
                Column column = this.table.AddColumn("2cm");
                column.Format.Alignment = ParagraphAlignment.Center;

                column = this.table.AddColumn("5cm");
                column.Format.Alignment = ParagraphAlignment.Left;

                column = this.table.AddColumn("4cm");
                column.Format.Alignment = ParagraphAlignment.Left;
                if (_Product.ProductID == 0)
                {
                    column = this.table.AddColumn("4cm");
                    column.Format.Alignment = ParagraphAlignment.Left;
                }

                column = this.table.AddColumn("3cm");
                column.Format.Alignment = ParagraphAlignment.Right;
                int countCellColumn = 0;

                // Create the header of the table
                Row row = table.AddRow();
                row.HeadingFormat = true;
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Format.Font.Bold = true;
                row.Shading.Color = HeaderColor;

                row.Cells[countCellColumn].AddParagraph("Invoice Number");
                row.Cells[countCellColumn].Format.Font.Bold = true;
                row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                countCellColumn++;

                row.Cells[countCellColumn].AddParagraph("Name");
                row.Cells[countCellColumn].Format.Font.Bold = true;
                row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                countCellColumn++;
                row.Cells[countCellColumn].AddParagraph("Occupation");
                row.Cells[countCellColumn].Format.Font.Bold = true;
                row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;

                countCellColumn++;

                if (_Product.ProductID == 0)
                {
                    row.Cells[countCellColumn].AddParagraph("Product");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;
                }

                row.Cells[countCellColumn].AddParagraph("Amount Due");
                row.Cells[countCellColumn].Format.Font.Bold = true;
                row.Cells[countCellColumn].Format.Alignment = ParagraphAlignment.Center;
                row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;

                if (UtilityService.StatementShowTableBoarders)
                    this.table.SetEdge(0, 0, countCellColumn, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

                Paragraph paragraph = this.addressFrame.AddParagraph();

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
                    row1.Cells[countCellValue].AddParagraph(transaction.Field<int>("InvoiceNumber").ToString());
                    countCellValue++;

                    row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                    row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                    row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Left;
                    row1.Cells[countCellValue].AddParagraph(transaction.Field<string>("ClientName"));
                    countCellValue++;

                    row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                    row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                    row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Left;
                    row1.Cells[countCellValue].AddParagraph(transaction.Field<string>("Occupation"));
                    countCellValue++;
                    if (_Product.ProductID == 0)
                    {
                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Left : ParagraphAlignment.Center;
                        row1.Cells[countCellValue].AddParagraph(transaction.Field<string>("Product"));
                        countCellValue++;
                    }




                    row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                    row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Right;
                    row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                    row1.Cells[countCellValue].AddParagraph(String.Format(culture, "{0:C}", transaction.Field<decimal>("AmountDue")));


                    finalCountCellValue = countCellValue;
                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(0, this.table.Rows.Count - 1, finalCountCellValue, 1, Edge.Box, BorderStyle.Single, 0.75);
                }

                // Add an invisible row as a space line to the table
                Row row2 = this.table.AddRow();
                row2.Borders.Visible = false;

                decimal TotalPaid = Transactions.AsEnumerable().Sum(transaction => transaction.Field<decimal>("AmountDue"));
                // Add the total due row
                row2 = this.table.AddRow();
                row2.Cells[0].Borders.Visible = false;
                row2.Cells[0].Format.Font.Bold = true;
                row2.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                row2.Cells[0].MergeRight = finalCountCellValue-1;
                row2.Cells[0].AddParagraph("Total Amount");
                row2.Cells[finalCountCellValue].AddParagraph(String.Format(culture, "{0:C}", TotalPaid));

                // Set the borders of the specified cell range
                if (UtilityService.StatementShowTableBoarders)
                    this.table.SetEdge(finalCountCellValue, this.table.Rows.Count - 1, 1, 1, Edge.Box, BorderStyle.Single, 0.75);



                // Add the notes paragraph
                paragraph = ReportingUtilities.PrintFootNotes(this.document.LastSection.AddParagraph());
            }
            catch (Exception e)
            {

                // ErrorLog.Log(e, ErrorSource.Reporting);
            }
        }
    }
}
