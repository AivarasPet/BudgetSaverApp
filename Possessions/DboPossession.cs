using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{
    public class DboPossession
    {
        public int ID { get; set; }
        public float Amount { get; set; }
        public int ApiLinkID { get; set; }
        public int LinkOfImageID { get; set; } 
//by this key, a picture for UI will be fetched from ImageFetcher
        public DateTime LastEdited { get; set; }
        public float ValueInDollarsWhenBought { get; set; }
        public int UserID { get; set; }
    }
}
