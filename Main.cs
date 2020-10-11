using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.Pricing;
using BudgetSaverApp.Possessions;

namespace BudgetSaverApp
{
    public class Main
    {
        public Main()
        {
            TransactionService.GetTransactionService().LoadTransactionsListFromTextFile();
            PossessionsService.GetPossessionsService().LoadPossessionsListFromTextFile();

            PortfolioService portfolioService = new PortfolioService();

            APIFetcher pricingFetcher = new APIFetcher();


            

        }
    }
}
