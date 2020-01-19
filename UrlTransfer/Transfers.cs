using System;
using System.Collections.Generic;
using System.Text;

namespace UrlTransfer
{
    public static class Transfers
    {
        public static string EncodingThunderUrl(string url)
        {
            string base64Url = EncodingBase64.EncodingBase64String(string.Format("AA{0}ZZ",url));
            return string.Format("Thunder://{0}",base64Url);
        }

        public static string DecodingThunderUrl(string thunderUrl)
        {
            int thunderIndex = thunderUrl.ToLower().IndexOf("thunder://")+10;
            string url = thunderUrl.Substring(thunderIndex);
            string decodingThunderUrl = EncodingBase64.DecodingBase64String(url);
            return decodingThunderUrl.Substring(2, decodingThunderUrl.Length - 4);
        }

        public static string EncodingFlashgetUrl(string url)
        {
            string base64Url = EncodingBase64.EncodingBase64String(string.Format("[FLASHGET]{0}[FLASHGET]",url));
            return string.Format("Flashget://{0}&2430",base64Url);
        }

        public static string DecodingFlashgetUrl(string flashgetUrl)
        {
            int flashgetIndex = flashgetUrl.ToLower().IndexOf("flashget://") + 11;
            int userInfo = flashgetUrl.LastIndexOf("&");
            int length = userInfo - flashgetIndex;
            string url = flashgetUrl.Substring(flashgetIndex, length);
            string decodingThunderUrl = EncodingBase64.DecodingBase64String(url);
            return decodingThunderUrl.Substring(10, decodingThunderUrl.Length - 20);
        }

        public static string EncodingQQDLUrl(string url)
        {
            string base64Url = EncodingBase64.EncodingBase64String(url);
            return string.Format("qqdl://{0}", base64Url);
        }

        public static string DecodingQQDLUrl(string qqdlUrl)
        {
            int thunderIndex = qqdlUrl.ToLower().IndexOf("qqdl://") + 7;
            string url = qqdlUrl.Substring(thunderIndex);
            return EncodingBase64.DecodingBase64String(url);
        }
    }
}
