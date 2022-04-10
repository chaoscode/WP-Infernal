using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WP_Infernal.Models.REST;

namespace WP_Infernal.Models.WP
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class WPAPI : RESTResponse
    {
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string home { get; set; }
        public string site_logo { get; set; }
        public int gmt_offset { get; set; }
        public string timezone_string { get; set; }
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public Namespace namespaces { get; set; }
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoints endpoints { get; set; }
        [JsonProperty("methods", NullValueHandling = NullValueHandling.Ignore)]
        public string[] methods { get; set; }
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Authentication authentication { get; set; }
        public Dictionary<string, Route> routes { get; set; }
        public _Links _links { get; set; }
    }

    public class Authentication
    {
        public ApplicationPasswords applicationpasswords { get; set; }
    }

    public class ApplicationPasswords
    {
        public Endpoints endpoints { get; set; }
    }

    public class Namespace
    {
        Dictionary<string, string> data { get; set; }
    }

    public class Endpoints
    {
        public string authorization { get; set; }
        public string[] methods { get; set; }
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public Args[] args;
    }

    public class Route
    {
        public string _namespace { get; set; }
        public string[] methods { get; set; }
        public Endpoint[] endpoints { get; set; }
        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public _Links _links { get; set; }
    }

    public class _Links
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Self[] self { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Endpoint
    {
        public string[] methods { get; set; }

        //[JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        //public  Dictionary<string, ArgItem> args { get; set; }
        
    }

    public class Args 
    {
        Dictionary<string, ArgItem> data { get; set; }
    }

    public class ArgItem
    {
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
        public int maxItems { get; set; }
        public Items items { get; set; }
    }
    public class Context
    {
        public string _default { get; set; }
        public bool required { get; set; }
    }
    public class Validation
    {
        public string type { get; set; }
        public string[] _enum { get; set; }
        public string _default { get; set; }
        public bool required { get; set; }
    }

    public class Requests
    {
        public string type { get; set; }
        public int maxItems { get; set; }
        public Items items { get; set; }
        public bool required { get; set; }
    }

    public class Items
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public Method method { get; set; }
        public Path path { get; set; }
        public Body body { get; set; }
        public Headers headers { get; set; }
    }

    public class Method
    {
        public string type { get; set; }
        public string[] _enum { get; set; }
        public string _default { get; set; }
    }

    public class Path
    {
        public string type { get; set; }
        public bool required { get; set; }
    }

    public class Body
    {
        public string type { get; set; }
        public object[] properties { get; set; }
        public bool additionalProperties { get; set; }
    }

    public class Headers
    {
        public string type { get; set; }
        public object[] properties { get; set; }
        public Additionalproperties additionalProperties { get; set; }
    }

    public class Additionalproperties
    {
        public string[] type { get; set; }
        public Items1 items { get; set; }
    }

    public class Items1
    {
        public string type { get; set; }
    }


}