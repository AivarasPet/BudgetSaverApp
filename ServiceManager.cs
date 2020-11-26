using BudgetSaverApp.Goals;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public class ServiceManager
    {
        public ITransactionService transactionService { get; }
        public IPosessionsService posessionsService { get; }
        public IStatisticsService statisticsService { get; }
        public IGoalsService goalsService { get; }
        public IUserDataService userDataService { get; }
        public ICategoryService categoryService { get; }

        public ServiceManager()
        {
            transactionService = TransactionsFactory.GetTransactionService();
            posessionsService = PossessionFactory.GetPossessionsService();
            statisticsService = StatisticsFactory.GetStatisticsService(transactionService);
            goalsService = GoalsFactory.GetGoalsService(statisticsService);
            userDataService = UserDataFactory.GetStatisticsService(goalsService);
            categoryService = CategoryFactory.GetStatisticsService();
        }
    }
}
