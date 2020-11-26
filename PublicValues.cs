using BudgetSaverApp.Possessions.Links;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public class PublicValues
    {

        private static float inflation = 0;

        public float InflationInARecentYear()
        {
            if (inflation != 0) return inflation;

            ApiLink api = new ApiLink
            {
                Link = "https://www.quandl.com/api/v3/datasets/RATEINF/CPI_USA.json?api_key=4SykxztoStAkUxdKf7Xd"
            };
            HttpRequest httpRequest = new HttpRequest();
            string result = httpRequest.StartHttpRequest(api);
            JObject jObject = JObject.Parse(result);
            var monthlyInflation = jObject["dataset"]["data"];
            var lastMonth = float.Parse(monthlyInflation[0][1].ToString());
            var lastYear = float.Parse(monthlyInflation[11][1].ToString());

            return (lastMonth - lastYear) / lastYear * 100;
        }
    }
}
