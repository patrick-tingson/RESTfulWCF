using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTfulWCF_And_HowToConsume
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestRESTfulWCF" in both code and config file together.
    [ServiceContract]
    public interface ITestRESTfulWCF
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CheckProfile/{ProfileId}",
            BodyStyle = WebMessageBodyStyle.Bare,
            ResponseFormat = WebMessageFormat.Json)]
        string CheckProfile(string ProfileId);

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "AddProfile/",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        ResponseProfile AddProfile(RequestProfile RequestProfileJSON); 
    } 
}
