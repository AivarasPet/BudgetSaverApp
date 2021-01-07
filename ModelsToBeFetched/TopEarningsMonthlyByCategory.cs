using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.ModelsToBeFetched
{
    public class TopEarningsMonthlyByCategory
    {
        public string Category { get; set; }
        public string Month { get; set; }
        public float Amount { get; set; }
    }
}
