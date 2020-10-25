using System;
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

        public async Task<string> StartHttpRequest(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            OnHttpRequestCompleted(responseBody);
            return responseBody;
        }

        protected virtual void OnHttpRequestCompleted(string text)
        {
            if (HttpRequestCompleted != null)
                HttpRequestCompleted(this, new MyEventArgs { data = text });
        }
    }
}
