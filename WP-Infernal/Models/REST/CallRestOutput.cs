using System.Net;

namespace WP_Infernal.Models.REST
{
    public class CallRestOutput
    {
        public bool Success { get; set; } = true;
        public WebExceptionStatus HTTPStatus { get; set; }
        public string Output { get; set; }
        public CookieCollection Cookies { get; set; }
        public string error;
        public string statuscode;
    }
}
