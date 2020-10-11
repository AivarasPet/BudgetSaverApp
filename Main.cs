using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            portfolioService.LoadDataFromTextFile();

            APIFetcher pricingFetcher = new APIFetcher();


            

        }
    }
}
