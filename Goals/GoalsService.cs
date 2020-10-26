using BudgetSaverApp.Goals;
using BudgetSaverApp.Statistics;
using System;

namespace BudgetSaverApp.Portfolio
{
    class GoalsService : IGoalsService
    {
        IStatisticsService StatisticsService;
        string _MainGoalName;
        float _MainGoalPrice;

        public GoalsService(IStatisticsService StatisticsService )
        {
            this.StatisticsService = StatisticsService;
            
        }

        public float GetProfitMonthly()
        {
            Stats StatsRecent30Days = this.StatisticsService.GetStatistic(DateTime.Now - TimeSpan.FromDays(30), DateTime.Now);
            return StatsRecent30Days.Income - StatsRecent30Days.Expenses;
        }

        public int GetGoalDaysLeft()
        {
            return (int)(_MainGoalPrice / (GetProfitMonthly().Daily()));
        }

        public string MainGoalName()
        {
            return _MainGoalName;
        }

        public float MainGoalPrice()
        {
            return _MainGoalPrice;
        }


        public void SetMainGoalName(string name)
        {
            _MainGoalName = name;
        }

        public void SetMainGoalPrice(float price)
        {
            _MainGoalPrice = price;
        }
    }
}
