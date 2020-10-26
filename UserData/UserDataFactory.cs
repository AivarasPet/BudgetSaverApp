using BudgetSaverApp.Goals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.UserData
{
    public class UserDataFactory
    {
        public static IUserDataService GetStatisticsService(IGoalsService goalsService)
        {
            return new UserDataService(goalsService);
        }
    }
}
