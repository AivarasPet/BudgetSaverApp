using BudgetSaverApp.Goals;
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
            ServiceManager serviceManager = new ServiceManager();
            Application.Run(new MainUI(serviceManager));           
        }
    }
}
