using System.Collections.Generic;
using System.Net;

namespace WP_Infernal.Models.REST
{
    public class CallRestInput
    {
        public string BodyData { get; set; } = string.Empty;
        public string URL { get; set; }
        public string Method { get; set; }
        public string AuthToken { get; set; } = string.Empty;
        public string BearerToken { get; set; } = string.Empty;
        public string Referer { get; set; } = string.Empty;
        public string Originating_PageOrApp { get; set; }
        public string contentType { get; set; } = "application/json";
        public string accept { get; set; }
        public CookieCollection Cookies { get; set; }
        public string TenableAuth { get; set; } = string.Empty;
        public Dictionary<string, string> CustomHeaderList { get; set; } = new Dictionary<string, string>();
        public bool ReturnNonErrorStatus { get; set; } = false;
    }
}
