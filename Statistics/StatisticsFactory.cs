namespace BudgetSaverApp.Statistics
{
    public class StatisticsFactory
    {
        public static IStatisticsService GetStatisticsService(ITransactionService transactionService)
        {
            return new StatisticsService(transactionService);
        }
    }
}
