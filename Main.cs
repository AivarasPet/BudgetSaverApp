using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.Pricing;

namespace BudgetSaverApp
{
    public class Main
    {
        public Main()
        {
            TransactionService.GetTransactionService().LoadTransactionsListFromTextFile();

            PortfolioService portfolioService = new PortfolioService();

            PricingFetcher pricingFetcher = new PricingFetcher();

        }
    }
}
