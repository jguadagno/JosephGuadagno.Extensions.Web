using System.Web;

namespace JosephGuadagno.Extensions.Web
{
    /// <summary>
    /// String Extensions for System.Web
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Encodes the input string as HTML (converts special characters to entities)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>HTML-encoded string</returns>
        public static string ToHtmlEncoded(this string input)
        {
            return HttpContext.Current.Server.HtmlEncode(input);
        }

        /// <summary>
        /// Encodes the input string as a URL (converts special characters to % codes)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>URL-encoded string</returns>
        public static string ToUrlEncoded(this string input)
        {
            return HttpContext.Current.Server.UrlEncode(input);
        }

        /// <summary>
        /// Decodes any HTML entities in the input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String</returns>
        public static string FromHtmlEncoded(this string input)
        {
            return HttpContext.Current.Server.HtmlDecode(input);
        }

        /// <summary>
        /// Decodes any URL codes (% codes) in the input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String</returns>
        public static string FromUrlEncoded(this string input)
        {
            return HttpContext.Current.Server.UrlDecode(input);
        }
    }
}