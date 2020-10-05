using BudgetSaverApp.Portfolio;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public class Main
    {
        public Main()
        {
            TransactionService.GetTransactionService().LoadTransactionsListFromTextFile();

            PortfolioService portfolioService = new PortfolioService();
            portfolioService.LoadDataFromTextFile();

            PricingFetcher pricingFetcher = new PricingFetcher();

        }
    }
}
