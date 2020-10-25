using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Statistics;

namespace BudgetSaverApp.Goals
{
    class GoalsFactory
    { 
        public static IGoalsService GetGoalsService(IStatisticsService statisticsService)
        {
            return new GoalsService(statisticsService);
        }
    }
}
