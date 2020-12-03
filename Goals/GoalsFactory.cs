using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Statistics;

namespace BudgetSaverApp.Goals
{
    class GoalsFactory
    { 
        public static IGoalsService GetGoalsService(ITransactionService transactionService)
        {
            return new GoalsService(transactionService);
        }
    }
}
