using BudgetSaverApp.Statistics;
using BudgetSaverApp.Portfolio;
using System;

namespace BudgetSaverApp
{
    class MonthlyIncome
    {
        UserData userData;
        IStatisticsService statisticsService;
        public MonthlyIncome(IStatisticsService statisticsService)
        {
            userData = new UserData();
            this.statisticsService = statisticsService;
        }
        public void RemainingMonthsToWork()
        {
            Stats stats = statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now);

            float goal = 50000;
            float salary = 111;
            float startingSavings = 64;
            float uGoal;

            int remainingMonths = 0;
            float  budget = startingSavings + stats.Income - stats.Expenses;
            uGoal = goal-budget;
            if ((uGoal) > 0)
            {
                while (uGoal > 0)
                {
                    uGoal -= salary;
                    remainingMonths++;
                }
            }
        }
    }
}
