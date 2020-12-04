using my_new_app.ModelsToBeFetched;
using System;
using System.Collections.Generic;

namespace BudgetSaverApp.Statistics
{
    public interface IStatisticsService
    {
        public Dictionary<string, Stats> LowestYearlyExpenesByCategory(Stats statsToBeCompared);
        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryAdvanced();
        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategory(DateTime monthComparedTo);
        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryPreviousMonth();
    }
}
