using Newtonsoft.Json.Linq;

namespace BudgetSaverApp.Possessions
{
    public class Crypto : Possession, IHasAPI
    {
        public static float marketCap;

        public void OnAPIDownload(string APIData)
        {
            JObject jObject = JObject.Parse(APIData);
            var price = jObject["Data"]["Data"][10]["open"];

            this.valueInDollars = amount * float.Parse(price.ToString());
        }
    }
}
