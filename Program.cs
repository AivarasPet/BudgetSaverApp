using BudgetSaverApp.Goals;
using BudgetSaverApp.ModelsToBeFetched;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Statistics;
using System;
using System.Collections.Generic;
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
            //DataAccess db = new DataAccess();
            //List<Transaction> hehe = db.GetTransactions();


            var context = new BudgetSaverDBEntities().Transactions;
            foreach (Transaction transaction in context) Console.WriteLine(transaction.Title);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ServiceManager serviceManager = new ServiceManager();
            Application.Run(new MainUI(serviceManager));           
        }
    }
}
