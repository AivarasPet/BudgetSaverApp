using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace BudgetSaverApp.Possessions
{
    class Stock : Possession, IApiCallback
    {
        public void OnAPIDownload(string APIData)
        {
            JObject jObject = JObject.Parse(APIData);
            var price = jObject["c"];

            this.ValueInDollars = Amount * float.Parse(price.ToString());
            if (Compare<float>(this.ValueInDollarsWhenBought) == false) this.PercentageChangeInValue = percentageChange(this.ValueInDollars, this.ValueInDollarsWhenBought);
            else this.PercentageChangeInValue = 0;
            Console.WriteLine(this.PercentageChangeInValue);
        }

        Func<float, float, float> percentageChange = (valueInDollars, valueInDollarsBought) => (valueInDollars + valueInDollarsBought) / valueInDollarsBought * 100;
        public bool Compare<T>(T x)
        {
            return EqualityComparer<T>.Default.Equals(x, default(T));
        }
    }
}

