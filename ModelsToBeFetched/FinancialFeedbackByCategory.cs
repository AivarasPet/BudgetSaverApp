using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.ModelsToBeFetched
{
    public class FinancialFeedbackByCategory
    {
        public float Difference { get; set; }
        public float PercentageDifference { get; set; }
        public bool IsFeedbackPositive { get; set; }
        public bool IsExpenses { get; set; }
        public string category { get; set; }
        public DateTime DateComparedTo { get; set; }
        public DateTime DateCompared { get; set; }
    }
}
