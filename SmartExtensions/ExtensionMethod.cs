using System;

namespace SmartExtensions
{
    public static class ExtensionMethod
    {
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
    }
}
