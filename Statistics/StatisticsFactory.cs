using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
