using BudgetSaverApp.Possessions.Links;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public class PublicValues
    {

        private static float inflation = 0;

        public static float InflationInARecentYear() //possessionPrice = PossessionPrice* ( inflation* daysLeft/365)
        {
            if (inflation != 0) return inflation;

            string link = "https://www.quandl.com/api/v3/datasets/RATEINF/CPI_USA.json?api_key=4SykxztoStAkUxdKf7Xd";
            if (link == null) return 0;
            ApiLink api = new ApiLink
            {
                Url = link
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
