using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WP_Infernal.Models.REST
{
   public class RESTResponse
    {
        public RESTError restError = new RESTError();
    }

    public class RESTError
    {
        public bool success;
        public List<string> messages = new List<string>();
        public string error;
    }
}
