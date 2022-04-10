using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Infernal.Models.WP
{
    public class ErrorResponse
    {
        public string code { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public int status { get; set; }
    }

}
