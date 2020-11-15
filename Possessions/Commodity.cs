using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace BudgetSaverApp.Possessions
{
    class Commodity : Possession, IApiCallback
    {
        public void OnAPIDownload(string APIData)
        {
              
            //JObject jObject = JObject.Parse(response.Content);
        }
    }
}
