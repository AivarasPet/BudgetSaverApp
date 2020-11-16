using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace BudgetSaverApp.Possessions
{
    class Commodity : Possession, IApiCallback
    {
        public void OnAPIDownload(string APIData)
        {
            string key = this.Name switch
            {
                "Silver" => "XAG",
                "Polyamide" => "PA",
                "Platinum" => "PL",
                "Gold" => "XAU",
                _ => ""
            };

            JObject jObject = JObject.Parse(APIData);
            ValueInDollars = Amount * float.Parse(jObject["rates"][key].ToString());
        }
    }
}
