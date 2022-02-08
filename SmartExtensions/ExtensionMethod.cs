using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace SmartExtensions
{
    public static class ExtensionMethod
    {
        static CultureInfo culture = new CultureInfo("en-US");

        public static string ToJson<T>(this T _object) => JsonConvert.SerializeObject((object)_object);

        public static string ToPrettyJson<T>(this T _object) => JsonConvert.SerializeObject((object)_object, Formatting.Indented);

        public static T FromJson<T>(this string _object) => JsonConvert.DeserializeObject<T>(_object);

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
        public static string EmailToMask(this string email)
        {
            string result = email;
            try
            {
               // string input = "jhon@abc.com";
                string pattern = @"(?<=[\w]{1})[\w-\._\+%]*(?=[\w]{1}@)";
                 result = Regex.Replace(email, pattern, m => new string('*', m.Length));

            }
            catch (Exception)
            {

            }
            return result;
        }

        public static string CreateDirectoryIfNotExists(this string directory)
        {
            string result = directory;
            try
            {
                bool exists = Directory.Exists(directory);
                if (!exists)
                    Directory.CreateDirectory(directory);
            }
            catch (Exception)
            {

            }
            return result;
        }
        public static string SerializetoJSON<T>(this T value)
        {
            string result = "An error occured";
            try
            {
                result = JsonConvert.SerializeObject(value);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
       
        public static T DeserializeFromJSON<T>(this string value)
        {           
            try
            {
                string result = "An error occured failed to convert";
                if (String.IsNullOrEmpty(value))
                    return (T)JsonConvert.DeserializeObject(result);
                else
                    return (T)JsonConvert.DeserializeObject(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public static byte[] BitmapToByteArray(this Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static bool ToBoolean(this string value)
        {
            bool result = false;
            try
            {
                result = bool.Parse(value);
            }
            catch (Exception ex)
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
