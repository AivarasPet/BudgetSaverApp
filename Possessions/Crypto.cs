using Newtonsoft.Json.Linq;
using System;

namespace BudgetSaverApp.Possessions
{
    public class Crypto : Possession, IApiCallback
    {
        public static float MarketCap;

        public void OnAPIDownload(string APIData)
        {
            JObject jObject = JObject.Parse(APIData);
            var price = jObject["Data"]["Data"][10]["open"];

            this.ValueInDollars = Amount * float.Parse(price.ToString());
            if (this.ValueInDollarsWhenBought != 0) this.PercentageChangeInValue = (this.ValueInDollars - this.ValueInDollarsWhenBought) / this.ValueInDollarsWhenBought * 100;
            else this.PercentageChangeInValue = 0;
            Console.WriteLine(price);
        }
    }
}
