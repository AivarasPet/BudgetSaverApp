using my_new_app.ModelsToBeFetched;
using System;
using System.Collections.Generic;
using static BudgetSaverApp.Statistics.StatisticsService;

namespace BudgetSaverApp.Statistics
{
    public interface IStatisticsService
    {
        public float DailyProfit(int userID);
        public string GetTopEarnings(int userID);
        //public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryAdvanced();
        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategory(DateTime monthComparedTo, int userID);
        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryPreviousMonth(int userID);
    }
}
