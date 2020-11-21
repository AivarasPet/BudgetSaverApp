using System;
using System.Collections.Generic;

namespace BudgetSaverApp.Statistics
{
    public interface IStatisticsService
    {
        public Stats GetStatistic(DateTime startDate, DateTime endDate);
        public Dictionary<string, Stats> LowestYearlyExpenesByCategory(Stats statsToBeCompared);
        public List<string> Suggestions();
    }
}
