using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTfulWCF_And_HowToConsume
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestRESTfulWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TestRESTfulWCF.svc or TestRESTfulWCF.svc.cs at the Solution Explorer and start debugging.
    public class TestRESTfulWCF : ITestRESTfulWCF
    {
        public string CheckProfile(string ProfileId)
        { 
            return string.Format("Profile ID {0} is VALID", ProfileId);
        }


        public ResponseProfile AddProfile(RequestProfile RequestProfileJSON)
        {
            var response = new ResponseProfile();
            response.RequestData = RequestProfileJSON;
            
            //Check if the ID is valid
            if (RequestProfileJSON.Id.Length == 0)
                return new ResponseProfile() { ResponseCode = "E1", ResponseDescription = "Invalid Id" }; 

            //Check if the Name is valid
            if (RequestProfileJSON.Name.Length == 0)
                return new ResponseProfile() { ResponseCode = "E2", ResponseDescription = "Invalid Name" };

            //Echo the request as test response
            response.ResponseCode = "00";
            response.ResponseDescription = "SUCCESSFUL";

            //Return the successful response
            return response; 
        }  
    }
}
