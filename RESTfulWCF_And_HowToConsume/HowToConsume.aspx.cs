using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RESTfulWCF_And_HowToConsume
{
    public partial class HowToConsume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        } 

        protected void btnCheckProfile_Click(object sender, EventArgs e)
        {
            var result = "";
            var endpoint = "http://localhost:6806/TestRESTfulWCF.svc/CheckProfile/";
            var transactionURL = string.Format("{0}{1}", endpoint, txtProfileID.Text);

            try
            {
                using (var webpage = new WebClient())
                {
                    result = webpage.DownloadString(transactionURL); 
                } 
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            txtResponse.Text = result;
        }

        protected void btnAddProfile_Click(object sender, EventArgs e)
        {
            var profile = new RequestProfile();
            profile.Id = txtProfileID0.Text;
            profile.Name = txtProfileName.Text;

            var responseString = "";

            string resquestParam = new JavaScriptSerializer().Serialize(profile);

            var endpoint = "http://localhost:6806/TestRESTfulWCF.svc/AddProfile/"; 

            WebRequest request = WebRequest.Create(endpoint);
            request.Method = "POST"; 
            request.ContentType = "application/json";
            request.ContentLength = resquestParam.Length;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(resquestParam);
                streamWriter.Close();
            }


            WebResponse response = request.GetResponse(); 
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                responseString = streamReader.ReadToEnd().Replace(":\":", "\":");
            }

            txtResponse.Text = responseString;
        }
    }
}