using BudgetSaverApp.Possessions;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.Transactions;
using System;
using System.Windows.Forms;

namespace BudgetSaverApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ITransactionService transactionService = TransactionsFactory.GetTransactionService();
            IPosessionsService posessionsService = PossessionFactory.GetPossessionsService();
            IStatisticsService statisticsService = StatisticsFactory.GetStatisticsService(transactionService);

            Application.Run(new MainUI(transactionService, posessionsService, statisticsService));
        }
    }
}
