using Newtonsoft.Json.Linq;
using System;

namespace BudgetSaverApp.Possessions
{
    class Stock : Possession, IApiCallback
    {
        public void OnAPIDownload(string APIData)
        {
            JObject jObject = JObject.Parse(APIData);
            var price = jObject["c"];

            this.ValueInDollars = Amount * float.Parse(price.ToString());
            if (this.ValueInDollarsWhenBought != 0) this.PercentageChangeInValue = (this.ValueInDollars - this.ValueInDollarsWhenBought) / this.ValueInDollarsWhenBought * 100;
            else this.PercentageChangeInValue = 0;


        }
    }
}

