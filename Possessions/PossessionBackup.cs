using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{

    public class PossessionBackup : IApiCallback
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public string UrlImage { get; set; }

        public void OnAPIDownload(string APIData)
        {
            JObject jObject = JObject.Parse(APIData);
            switch (this.Type)
            {
                case "Stock":
                    this.Price = float.Parse(jObject["c"].ToString());
                    break;
                case "Crypto":
                    if (jObject["Response"].ToString().ToLower() == "error") this.Price = 0;
                    else this.Price = float.Parse(jObject["Data"]["Data"][10]["open"].ToString());
                    break;
                case "Commodity":

                    break;
            }

        }
    }

}
