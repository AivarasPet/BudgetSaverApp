using BudgetSaverApp.Possessions.Links;
using Newtonsoft.Json;
using System;

namespace BudgetSaverApp.Possessions
{
    [JsonConverter(typeof(BaseConverter))]
    public class Possession {

        public string Type { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public float ValueInDollars { get; set; }
        public int ApiLinkID { get; set; }
        public int LinkOfImageID { get; set; } //by this key, a picture for UI will be fetched from ImageFetcher
        public string ImageUrl { get; set;}
        public DateTime LastEdited { get; set; }
        public float ValueInDollarsWhenBought { get; set; }
        public float PercentageChangeInValue { get; set; }


    }
}
