using MigraDoc.DocumentObjectModel;
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
  public  class SchedulePrintOut
    {
        Document document;
        Table table;
        Color TableColor = Colors.LightGray;
        Color TableBorder = Colors.Black;
        Color WhiteColor = Colors.White;
        Color HeaderColor = Colors.LightGray;
        TextFrame addressFrame;
               DateTime _CutOffDate;
        CultureInfo culture;
        Section section;
        Style style;
        Product _Product;


        public Document Print(Product Product, DateTime CutOffDate)
        {
            try
            {

                // Create a new MigraDoc document
                this.document = new Document();
                this.document = ReportingUtilities.DocumentMetaData(this.document, "Salary Schedule");
                this._Product = Product;
                this._CutOffDate = CutOffDate;
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



                //// Each item fills two rows
                //Row tblrow = this.table.AddRow();

                //tblrow.TopPadding = 1.5;
                //tblrow.Cells[0].Borders.Visible = false;
                //tblrow.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                //tblrow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                //tblrow.Cells[0].Format.Font.Bold = true;
                //tblrow.Cells[0].AddParagraph(UtilityService.IsNotNull(guarantor) ? guarantor.GuarantorFullName : _statement.Client.ClientFullName.Trim());


                //Row tblrow1 = this.table.AddRow();
                //tblrow1.Borders.Visible = false;
                //tblrow1.TopPadding = 1.5;

                //tblrow1.Cells[0].Borders.Visible = false;
                //tblrow1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                //tblrow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                //tblrow1.Cells[0].AddParagraph(UtilityService.IsNotNull(guarantor) ? guarantor.PhysicalAddress : _statement.Client.ResidentialAddress.Trim());

                //Row tblrow2 = this.table.AddRow();
                //tblrow2.Borders.Visible = false;
                //tblrow2.TopPadding = 1.5;
                //tblrow2.Cells[0].Borders.Visible = false;
                //tblrow2.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                //tblrow2.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                //tblrow2.Cells[0].AddParagraph(UtilityService.IsNotNull(guarantor) ? guarantor.EmailAddress : _statement.Client.EmailAddress);

                //Row tblrow3 = this.table.AddRow();
                //tblrow3.Borders.Visible = false;
                //tblrow3.TopPadding = 1.5;
                //tblrow3.Cells[0].Borders.Visible = false;
                //tblrow3.Cells[0].Format.Font.Bold = true;
                //tblrow3.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                //tblrow3.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                //tblrow3.Cells[0].AddParagraph(UtilityService.IsNotNull(guarantor) ? guarantor.MobileNumber : _statement.Client.MobileNumber.Trim());


                //paragraph = section.AddParagraph();
            }

            catch (Exception e)
            {

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

                tblrow.Cells[2].Borders.Visible = false;
                tblrow.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[2].Format.Font.Bold = true;
                tblrow.Cells[2].AddParagraph("Cut Off Date");

                tblrow.Cells[3].Borders.Visible = false;
                tblrow.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[3].AddParagraph(UtilityService.ShowDate(_CutOffDate));

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
                tblrow1.Cells[1].AddParagraph(UtilityService.CurrentUserName);

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


                string _selectClause = @"SELECT CONCAT(c.LastName,' ', c.FirstName) AS ClientName, p.Name AS Product,cd.DeductedAmount AS AmountDue, cd.DueDate,c.Occupation FROM ClientDeductions cd
                                            INNER JOIN Clients c ON cd.ClientID=c.ClientID
                                            INNER JOIN Products p ON p.ProductID=cd.ProductID ";

                string sqlQuery = _selectClause + $"WHERE  cd.DueDate='{_CutOffDate.ToString("yyyy-MM-dd")}'";
                if (_Product.ProductID > 0)
                    sqlQuery = sqlQuery + $" AND cd.ProductID={_Product.ProductID}";

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
                Column column = this.table.AddColumn("3cm");
                column.Format.Alignment = ParagraphAlignment.Center;

                column = this.table.AddColumn("3cm");
                column.Format.Alignment = ParagraphAlignment.Right;

                column = this.table.AddColumn("8cm");
                column.Format.Alignment = ParagraphAlignment.Right;



                column = this.table.AddColumn("3cm");
                column.Format.Alignment = ParagraphAlignment.Right;

                // Create the header of the table
                Row row = table.AddRow();
                row.HeadingFormat = true;
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Format.Font.Bold = true;
                row.Shading.Color = HeaderColor;

                row.Cells[0].AddParagraph("Name");
                row.Cells[0].Format.Font.Bold = true;
                row.Cells[0].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;

                row.Cells[1].AddParagraph("Occupation");
                row.Cells[1].Format.Font.Bold = true;
                row.Cells[1].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                row.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;

                row.Cells[2].AddParagraph("Product");
                row.Cells[2].Format.Font.Bold = true;
                row.Cells[2].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                row.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;

              
                row.Cells[3].AddParagraph("Amount Due");
                row.Cells[3].Format.Font.Bold = true;
                row.Cells[3].Format.Alignment = ParagraphAlignment.Center;
                row.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;

                if (UtilityService.StatementShowTableBoarders)
                    this.table.SetEdge(0, 0, 4, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

                Paragraph paragraph = this.addressFrame.AddParagraph();


                foreach (DataRow transaction in Transactions.Rows)
                {

                    // Each item fills two rows
                    Row row1 = this.table.AddRow();

                    row1.TopPadding = 1.5;
                    row1.Cells[0].Borders.Visible = UtilityService.StatementShowTableBoarders;
                    row1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                    row1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    row1.Cells[0].AddParagraph(transaction.Field<string>("ClientName"));

                    row1.Cells[1].Borders.Visible = UtilityService.StatementShowTableBoarders;
                    row1.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;
                    row1.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                    row1.Cells[1].AddParagraph(transaction.Field<string>("Occupation"));

                    row1.Cells[2].Borders.Visible = UtilityService.StatementShowTableBoarders;
                    row1.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;
                    row1.Cells[2].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Left : ParagraphAlignment.Center;
                    row1.Cells[2].AddParagraph(transaction.Field<string>("Product"));


                    
                    row1.Cells[3].Borders.Visible = UtilityService.StatementShowTableBoarders;
                    row1.Cells[3].Format.Alignment = ParagraphAlignment.Right;
                    row1.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;
                    row1.Cells[3].AddParagraph(String.Format(culture, "{0:C}", transaction.Field<decimal>("AmountDue")));

                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(0, this.table.Rows.Count - 1, 4, 1, Edge.Box, BorderStyle.Single, 0.75);
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
                row2.Cells[0].MergeRight = 2;
                row2.Cells[0].AddParagraph("Total Amount");
                row2.Cells[3].AddParagraph(String.Format(culture, "{0:C}", TotalPaid));

                // Set the borders of the specified cell range
                if (UtilityService.StatementShowTableBoarders)
                    this.table.SetEdge(3, this.table.Rows.Count - 1, 1, 1, Edge.Box, BorderStyle.Single, 0.75);



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

