
using MigraDocCore.DocumentObjectModel;
using MigraDocCore.DocumentObjectModel.MigraDoc.DocumentObjectModel.Shapes;
using MigraDocCore.DocumentObjectModel.Shapes;
using PdfSharpCore.Utils;
using SixLabors.ImageSharp.PixelFormats;
using SmartHelper;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;
using static MigraDocCore.DocumentObjectModel.MigraDoc.DocumentObjectModel.Shapes.ImageSource;

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
            Image image = null;
            try
            {
                // Put a logo in the header
                //string imagePath = UtilityService.IsNotNull((UtilityService.CompanyLogo)) ? MigraDocFilenameFromByteArray(UtilityService.CompanyLogo) : "";

                if (ImageSource.ImageSourceImpl == null)
                    ImageSource.ImageSourceImpl = new ImageSharpImageSource<Rgba32>();
                var imageSource = FromBinary("logonew.png", () => UtilityService.CompanyLogo);
                 image = section.Headers.Primary.AddImage(imageSource);
                image.Height = "1.5cm";
                image.LockAspectRatio = true;
                image.RelativeVertical = RelativeVertical.Line;
                image.RelativeHorizontal = RelativeHorizontal.Margin;
                image.Top = ShapePosition.Center;
                image.Left = ShapePosition.Center;
                image.WrapFormat.Style = WrapStyle.Through;
                     }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
            return image;
        }
        public static Section SetMargins(Section section)
        {
            try
            {

                section.PageSetup.TopMargin = Unit.FromCentimeter(3);
                section.PageSetup.BottomMargin = Unit.FromCentimeter(3);
                return section;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
        }
        public static Paragraph PrintFooter(Section section)
        {

            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            string reportFooter1 = UtilityService.Report_Footer_1;
            if (!String.IsNullOrEmpty(reportFooter1))
                paragraph.AddText(reportFooter1);
            string reportFooter2 = UtilityService.Report_Footer_2;
            if (!String.IsNullOrEmpty(reportFooter2))
            {
                paragraph.AddLineBreak();
                paragraph.AddText(reportFooter2);
            }
            paragraph.Format.Font.Name = UtilityService.IsNull(UtilityService.ReportFooterFontName) ? (UtilityService.IsNull(UtilityService.ReportBodyFontName) ? "Arial" : UtilityService.ReportBodyFontName ): UtilityService.ReportFooterFontName;
            paragraph.Format.Font.Size = UtilityService.ReportFooterFontSize == 0 ? 8 : UtilityService.ReportFooterFontSize;
          
            return paragraph;
        }
      
        public static Document DocumentMetaData(Document document, string DocumentTitle)
        {
            try
            {                                 document.Info.Title = DocumentTitle;
            document.Info.Subject = UtilityService.ApplicationName;
            document.Info.Author = "Caroline Chirenje";
            return document;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
            }
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
                style.Font.Name = UtilityService.IsNull(UtilityService.ReportBodyFontName) ? "Arial" : UtilityService.ReportBodyFontName;
                style.Font.Size = UtilityService.ReportBodyFontSize == 0 ? 8 : UtilityService.ReportBodyFontSize;

                style = document.Styles[StyleNames.Header];
                style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

                style = document.Styles[StyleNames.Footer];
                style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

                // Create a new style called Table based on style Normal
                style = document.Styles.AddStyle("Table", "Normal");
                style.Font.Name = UtilityService.IsNull(UtilityService.ReportBodyFontName) ? "Arial" : UtilityService.ReportBodyFontName;
                style.Font.Size = UtilityService.ReportBodyFontSize==0? 8:UtilityService.ReportBodyFontSize;

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
                style.Font.Size = UtilityService.ReportBodyFontSize == 0 ? 8 : UtilityService.ReportBodyFontSize;

                // Create a new style called Reference based on style Normal
                style = document.Styles.AddStyle("LoanDetails", "Normal");
                style.ParagraphFormat.SpaceBefore = "5mm";
                style.ParagraphFormat.SpaceAfter = "5mm";
                style.ParagraphFormat.TabStops.AddTabStop("2.5cm", TabAlignment.Left);
                style.Font.Size = UtilityService.ReportBodyFontSize == 0 ? 8 : UtilityService.ReportBodyFontSize;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
                throw;
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
