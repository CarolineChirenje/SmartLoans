using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHelper
{  
     public static class Encryption
    {
        private static readonly string key = UtilityService.GetMessageToDisplay("ENCYPTKEY");
        public static string Encrypt(string input)
        {
            try
            {
                byte[] oByte = new byte[input.Length];
                oByte = Encoding.UTF8.GetBytes(input);
                string EncodedData = Convert.ToBase64String(oByte);
                return EncodedData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static string Decrypt(string input)
        {
            try
            {
                UTF8Encoding oUTF8Encoding = new System.Text.UTF8Encoding();
                Decoder oDecoder = oUTF8Encoding.GetDecoder();
                byte[] oByte = Convert.FromBase64String(input);
                int CharCount = oDecoder.GetCharCount(oByte, 0, oByte.Length);
                char[] DecodedChar = new char[CharCount];
                oDecoder.GetChars(oByte, 0, oByte.Length, DecodedChar, 0);
                string DecodedData = new String(DecodedChar);
                return DecodedData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

