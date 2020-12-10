using BudgetSaverApp.Goals;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.Transactions;
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
            DataAccess db = new DataAccess();
            List<Transaction> hehe = db.GetTransactions(); 
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ServiceManager serviceManager = new ServiceManager();
            //Application.Run(new MainUI(serviceManager));           
        }
    }
}
