using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;

namespace SmartReporting
{
    public class ReportingUtilities
    {
        static string MigraDocFilenameFromByteArray(byte[] image)
        {
            return "base64:" +
                   Convert.ToBase64String(image);
        }
        public static Image PrintHeaderLogo(Section section)
        {


            // Put a logo in the header
            string imagePath = UtilityService.IsNotNull((UtilityService.CompanyLogo))? MigraDocFilenameFromByteArray(UtilityService.CompanyLogo):"";
            Image image = section.Headers.Primary.AddImage(imagePath);
            image.Height = "1.5cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Center;
            image.Left = ShapePosition.Center;
            image.WrapFormat.Style = WrapStyle.Through;
            return image;
        }

        public static Paragraph PrintFooter(Section section)
        {
            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddText(UtilityService.Report_Footer_1);
            string reportFooter2 = UtilityService.Report_Footer_2;
            if (!String.IsNullOrEmpty(reportFooter2))
            {
                paragraph.AddLineBreak();
                paragraph.AddText(reportFooter2);
            }
            paragraph.Format.Font.Size = 9;
            return paragraph;
        }
        public static Paragraph PrintFootNotes(Paragraph paragraph)
        {

            paragraph.Format.SpaceBefore = "2cm";
            paragraph.Format.Font.Size = 8;
            // paragraph.Format.Font.ApplyFont(new Font("Lucida Handwriting"));
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddText("");
            paragraph.AddLineBreak();
            paragraph.AddText("");
            paragraph.AddLineBreak();
            paragraph.AddText("");
            paragraph.AddLineBreak();
            paragraph.AddText("");

            return paragraph;
        }
        public static Document DocumentMetaData(Document document, string DocumentTitle)
        {
            document.Info.Title = DocumentTitle;
            document.Info.Subject = UtilityService.ApplicationName;
            document.Info.Author = "Caroline Chirenje";
            return document;
        }
        public static Style DefineStyles(Document document)
        {
            Style style = document.Styles["Normal"];
            try
            {
                // Get the predefined style Normal.
                style = document.Styles["Normal"];
                // Because all styles are derived from Normal, the next line changes the 
                // font of the whole document. Or, more exactly, it changes the font of
                // all styles and paragraphs that do not redefine the font.
                style.Font.Name = "Calibri";

                style = document.Styles[StyleNames.Header];
                style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

                style = document.Styles[StyleNames.Footer];
                style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

                // Create a new style called Table based on style Normal
                style = document.Styles.AddStyle("Table", "Normal");
                style.Font.Name = "Calibri";
                style.Font.Size = 9;

                // Create a new style called Reference based on style Normal
                style = document.Styles.AddStyle("Reference", "Normal");
                style.ParagraphFormat.SpaceBefore = "5mm";
                style.ParagraphFormat.SpaceAfter = "5mm";
                style.ParagraphFormat.TabStops.AddTabStop("10cm", TabAlignment.Left);


                // Create a new style called Reference based on style Normal
                style = document.Styles.AddStyle("Address", "Normal");
                style.ParagraphFormat.SpaceBefore = "5mm";
                style.ParagraphFormat.SpaceAfter = "5mm";
                style.ParagraphFormat.TabStops.AddTabStop("10cm", TabAlignment.Left);
                style.Font.Size = 8;


                // Create a new style called Reference based on style Normal
                style = document.Styles.AddStyle("LoanDetails", "Normal");
                style.ParagraphFormat.SpaceBefore = "5mm";
                style.ParagraphFormat.SpaceAfter = "5mm";
                style.ParagraphFormat.TabStops.AddTabStop("2.5cm", TabAlignment.Left);
                style.Font.Size = 8;


            }
            catch (Exception e)
            {

                //  ErrorLog.Log(e, ErrorSource.Reporting);
            }


            return style;
        }

        public static string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static string ConcatWithHyphen(string narration, string notes)
        {
            if (String.IsNullOrEmpty(narration) && !String.IsNullOrEmpty(notes))
                return notes;

            if (!String.IsNullOrEmpty(narration) && String.IsNullOrEmpty(notes))
                return narration;

            if (!String.IsNullOrEmpty(narration) && !String.IsNullOrEmpty(notes))
                return String.Concat(narration, " - ", notes);

            return String.Empty;
        }


      
    }
}
