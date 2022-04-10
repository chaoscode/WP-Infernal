using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_Infernal.Models.REST;
using Newtonsoft.Json;
using WP_Infernal.Models.WP;
using WP_Infernal.Managers.Helper;

namespace WP_Infernal.Managers.WP
{
    class WPAPIManager
    {
        private string _baseURL = ""; //Set SS Path here
        public string BaseURL
        {
            get => _baseURL;
            set => _baseURL = value;
        }
        private string _basePath = "wp-json";
        private string text;

        public WPAPIManager(string _baseurl)
        {
            this.BaseURL = _baseurl;
        }

        public string BasePath
        {
            get => _basePath;
            set => _basePath = value;
        }
        public CallRestOutput testEndPoint(string endpointPath, string method)
        {
            // Create response object
            CallRestOutput outpt = new CallRestOutput();

            // Create request object
            CallRestInput inpt = new CallRestInput();

            // Setup request
            inpt.URL = _baseURL + _basePath + endpointPath;
            inpt.Method = method;

            REST.RestManager RESTMgr = new REST.RestManager();

            // Get results of Rest call
            CallRestOutput RestResult = RESTMgr.CallREST(inpt);

            return RestResult;
        }
                
        public WPAPI getAPIdata()
        {
            // Create return object
            WPAPI result = new WPAPI();

            // Create response object
            CallRestOutput outpt = new CallRestOutput();

            // Create request object
            CallRestInput inpt = new CallRestInput();

            // Setup request
            inpt.URL = _baseURL + _basePath;
            inpt.Method = "GET";            

            REST.RestManager RESTMgr = new REST.RestManager();

            // Get results of Rest call
            CallRestOutput RestResult = RESTMgr.CallREST(inpt);

            try
            {

                // Handle SS errors
                if (RestResult.statuscode == "OK")
                {
                    // Populate the response object
                    JsonConvert.PopulateObject(RestResult.Output, result, new JsonSerializerSettings()
                                                {
                                                    ContractResolver = new IgnoreEmptyEnumerablesResolver(),
                                                    NullValueHandling = NullValueHandling.Ignore
                                                }
                    );

                    result.restError.success = true;
                }
                else if (RestResult.statuscode == "BadRequest")
                {
                    result.restError.error = RestResult.statuscode;
                    result.restError.success = false;
                }
                else if (RestResult.statuscode == "Unauthorized")
                {
                    result.restError.error = RestResult.statuscode;
                    result.restError.success = false;
                }
                else
                {
                    // Set error
                    result.restError.success = false;                    
                }
            }

            // Catch any request errors
            catch (Exception ex)
            {
                result.restError = new RESTError();
                result.restError.success = false;
                result.restError.messages.Add("Error: " + ex.Message);
                result.restError.messages.Add("WebResponse: " + RestResult.Output);
            }

            return result;

        }
    }
}
