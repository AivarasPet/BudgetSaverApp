using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
