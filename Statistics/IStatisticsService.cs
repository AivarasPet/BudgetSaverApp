using System;

namespace BudgetSaverApp.Statistics
{
    public interface IStatisticsService
    {
        public Stats GetStatistic(DateTime startDate, DateTime endDate);
    
    }
}
