using System;
using System.Collections.Generic;
using System.Text;

namespace UrlTransfer
{
    public static class EncodingBase64
    {
        public static string EncodingBase64String(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            return Convert.ToBase64String(bytes);
        }

        public static string DecodingBase64String(string base64str)
        {
            byte[] bytes = Convert.FromBase64String(base64str);
            return Encoding.Default.GetString(bytes);
        }
    }
}
