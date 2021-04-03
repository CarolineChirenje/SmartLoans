using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;

namespace SmartReporting
{
    public class AttendanceRegisterPrintOut
    {
        Document document;
        Table table;
        Color TableColor = Colors.LightGray;
        Color TableBorder = Colors.Black;
        Color HeaderColor = Colors.LightGray;
        TextFrame addressFrame;
        AttendanceRegister _register;

        CultureInfo culture;
        Section section;
        Style style;


        public Document Print(AttendanceRegister register)
        {
            try
            {

                // Create a new MigraDoc document
                this.document = new Document();
                this.document = ReportingUtilities.DocumentMetaData(this.document, "Attendance Register");
                this._register = register;
                this.culture = new CultureInfo("en-US");
                style = ReportingUtilities.DefineStyles(this.document);
                AddressAndHeader();
                RegisterDetails();
                AttendanceList();
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



                string title = $"ATTENDANCE REGISTER";

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
                tblrow.Cells[0].AddParagraph(_register.CourseIntake.Course.Title);

                Row tblrow1 = this.table.AddRow();
                tblrow1.Borders.Visible = false;
                tblrow1.TopPadding = 1.5;
                tblrow1.Cells[0].Borders.Visible = false;
                tblrow1.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tblrow1.Cells[0].AddParagraph(_register.CourseIntake.Name);

                Row tblrow2 = this.table.AddRow();
                tblrow2.Borders.Visible = false;
                tblrow2.TopPadding = 1.5;
                tblrow2.Cells[0].Borders.Visible = false;
                tblrow2.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow2.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tblrow2.Cells[0].AddParagraph(_register.CourseIntake.Period);

                paragraph = section.AddParagraph();
            }

            catch (Exception e)
            {

                //   ErrorLog.Log(e, ErrorSource.Reporting);
            }
        }

        void RegisterDetails()
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
                tblrow.Cells[0].AddParagraph("Requested By");

                tblrow.Cells[1].Borders.Visible = false;
                tblrow.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[1].AddParagraph(_register.RequestedBy);

                tblrow.Cells[2].Borders.Visible = false;
                tblrow.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[2].Format.Font.Bold = true;
                tblrow.Cells[2].AddParagraph("Attendance Date");

                tblrow.Cells[3].Borders.Visible = false;
                tblrow.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                tblrow.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;
                tblrow.Cells[3].AddParagraph(_register.AttendanceDate);
                              

                paragraph = section.AddParagraph();
            }

            catch (Exception e)
            {

                //  ErrorLog.Log(e, ErrorSource.Reporting);
            }
        }
        void AttendanceList()
        {

            try
            {


                List<AttendanceRegisterDetail> details = _register.AttendanceRegisterDetails.ToList();
                Paragraph paragraph = null;
                if (details != null && details.Count > 0)
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
                    Column column = this.table.AddColumn("10cm");
                    column.Format.Alignment = ParagraphAlignment.Left;

                    column = this.table.AddColumn("5cm");
                    column.Format.Alignment = ParagraphAlignment.Center;

                                       // Create the header of the table
                    Row row = table.AddRow();
                    row.HeadingFormat = true;
                    row.Format.Alignment = ParagraphAlignment.Center;
                    row.Format.Font.Bold = true;
                    row.Shading.Color = HeaderColor;
                    int countCellColumn = 0;
                    row.Cells[countCellColumn].AddParagraph("Employee");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;
                    row.Cells[countCellColumn].AddParagraph("Attendance Status");
                    row.Cells[countCellColumn].Format.Font.Bold = true;
                    row.Cells[countCellColumn].Format.Alignment = UtilityService.StatementShowTableBoarders ? ParagraphAlignment.Center : ParagraphAlignment.Left;
                    row.Cells[countCellColumn].VerticalAlignment = VerticalAlignment.Bottom;
                    countCellColumn++;

                   
                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(0, 0, countCellColumn, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

                    paragraph = this.addressFrame.AddParagraph();

                    int finalCountCellValue = 0;
                    foreach (var detail in details)
                    {
                        int countCellValue = 0;
                        // Each item fills two rows
                        Row row1 = this.table.AddRow();

                        row1.TopPadding = 1.5;
                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].Format.Alignment = ParagraphAlignment.Left;
                        row1.Cells[countCellValue].AddParagraph(detail.Client.ClientFullName);
                        countCellValue++;

                        row1.Cells[countCellValue].Borders.Visible = UtilityService.StatementShowTableBoarders;
                        row1.Cells[countCellValue].VerticalAlignment = VerticalAlignment.Bottom;
                        row1.Cells[countCellValue].Format.Alignment =  ParagraphAlignment.Center;
                        row1.Cells[countCellValue].AddParagraph(detail.AttendanceStatus);
                    
                          finalCountCellValue = countCellValue;
                        if (UtilityService.StatementShowTableBoarders)
                            this.table.SetEdge(0, this.table.Rows.Count - 1, finalCountCellValue + 1, 1, Edge.Box, BorderStyle.Single, 0.75);
                    }

                    // Add an invisible row as a space line to the table
                    Row row2 = this.table.AddRow();
                    row2.Borders.Visible = false;

                    int total = details.Count();
                    int present = details.Where(d => d.Present).ToList().Count();
                    decimal percent = 0M;
                    if (total != 0)
                    {
                        decimal percentage = (present / total) * 100;
                        percent = Math.Round(percentage, MidpointRounding.AwayFromZero);
                    }
                    // Add the total due row
                    row2 = this.table.AddRow();
                    row2.Cells[0].Borders.Visible = false;
                    row2.Cells[0].Format.Font.Bold = true;
                    row2.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                    row2.Cells[0].MergeRight = finalCountCellValue - 1;
                    row2.Cells[0].AddParagraph("Percentage Turn Out");
                    row2.Cells[finalCountCellValue].AddParagraph($"{percent.ToString()}%");

                    // Set the borders of the specified cell range
                    if (UtilityService.StatementShowTableBoarders)
                        this.table.SetEdge(finalCountCellValue, this.table.Rows.Count - 1, 1, 1, Edge.Box, BorderStyle.Single, 0.75);
                    paragraph = this.addressFrame.AddParagraph();
                   
                    //paragraph = section.AddParagraph();
                    //paragraph = this.addressFrame.AddParagraph();
                    //paragraph.AddText("");
                    //paragraph.AddLineBreak();
                    //paragraph.AddText("* P = Present A = Absent");

                }
                else
                    paragraph = this.addressFrame.AddParagraph();
               
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
