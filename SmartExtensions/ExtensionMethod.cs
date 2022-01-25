using System;
using System.Globalization;

namespace SmartExtensions
{
    public static class ExtensionMethod
    {
       static CultureInfo culture = new CultureInfo("en-US");
        public static int ToInt(this string value)
        {
            int result = 0;
            try
            {
                result = Int32.Parse(value);
            }
            catch
            {

            }
            return result;
        }
        public static decimal ToDecimal(this string value)
        {
            decimal result = 0;
            try
            {
                result = decimal.Parse(value, culture);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
      
        public static string ToFormattedNumbers(this string value)
        {
            string result = "0.00";
            try
            {
                result = $"{value.ToDecimal():N}";
            }
            catch
            {

            }
            return result;
        }
        public static string ToFormattedCurrency(this string value)
        {
            string result = "0.00:C";
            try
            {

                result = String.Format(culture, "{0:C}", value.ToDecimal());
            }
            catch
            {

            }
            return result;
        }
    }
}
