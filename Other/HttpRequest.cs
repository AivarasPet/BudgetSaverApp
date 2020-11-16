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
    class HttpRequest
    {
        public delegate void HttpRequestDownloaderEventhandler(object source, MyEventArgs args);
        public event HttpRequestDownloaderEventhandler HttpRequestCompleted;

        public async Task<string> StartHttpRequest(ApiLink apiLink)
        {
            var client = new RestClient(apiLink.Link);
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
            //Console.WriteLine(request.Parameters.ElementAt(0));
        }

        protected virtual void OnHttpRequestCompleted(string text)
        {
            if (HttpRequestCompleted != null)
                HttpRequestCompleted(this, new MyEventArgs { data = text });
        }
    }
}
