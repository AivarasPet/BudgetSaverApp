using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{
    public class DboPossession
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public string ApiLinkID { get; set; }
        public string LinkOfImage { get; set; } //by this key, a picture for UI will be fetched from ImageFetcher
        public DateTime LastEdited { get; set; }
        public float ValueInDollarsWhenBought { get; set; }

    }
}
