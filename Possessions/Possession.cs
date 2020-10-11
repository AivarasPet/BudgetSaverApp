using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{
    public abstract class Possession
    {
        public string name { get; set; }
        public float amount {get; set;}
        public float valueInDollars { get; set; }
        public string linkOfAPI { get; set; }
        public string imageKey { get; set; } //by this key, a picture for UI will be fetched from ImageFetcher
        public DateTime lastEdited { get; set; }

        public void AddAmount(float toAdd) {
            amount += toAdd;
        }

        public void SubAmount(float toSub)
        {
            amount -= toSub;
            if (amount < 0) { }//delete
        }

        //public abstract void InitValues(string apiData);

   
    }
}
