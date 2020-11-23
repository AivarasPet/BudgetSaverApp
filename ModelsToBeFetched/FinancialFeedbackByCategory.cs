using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.ModelsToBeFetched
{
    public class FinancialFeedbackByCategory
    {
        public float Difference;
        public float PercentageDifference;
        public bool IsFeedbackPositive;
        public bool IsExpenses;
        public string category;
        public DateTime DateComparedTo;
        public DateTime DateCompared;
    }
}
