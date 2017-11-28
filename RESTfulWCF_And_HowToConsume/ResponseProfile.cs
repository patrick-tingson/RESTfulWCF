using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTfulWCF_And_HowToConsume
{
    public class ResponseProfile
    {
        public RequestProfile RequestData { get; set; } 
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
    }
}