﻿using my_new_app.ModelsToBeFetched;
using System;
using System.Collections.Generic;
using static BudgetSaverApp.Statistics.StatisticsService;

namespace BudgetSaverApp.Statistics
{
    public interface IStatisticsService
    {
        public string getTopEarnings(int userID);
        //public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryAdvanced();
        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategory(DateTime monthComparedTo, int userID);
        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryPreviousMonth(int userID);
    }
}
