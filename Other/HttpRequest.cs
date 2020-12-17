using BudgetSaverApp.Possessions.Links;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BudgetSaverApp
{

    public class MyEventArgs : EventArgs
    {
        public string data { get; set; }
    }

    public class HttpRequest
    {

        public String StartHttpRequest(ApiLink apiLink)
        {
            var client = new RestClient(apiLink.Url);
            var request = new RestRequest(Method.GET);
            if (apiLink.Headers != null)
            {
                foreach (KeyValuePair<string, string> entry in apiLink.Headers)
                {
                    request.AddHeader(entry.Key, entry.Value);
                }
            }
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

    }
}
