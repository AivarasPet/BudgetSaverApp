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
            ServiceManager serviceManager = new ServiceManager();    
            //LoadOldTransactions(serviceManager);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUI(serviceManager));

        }

        static void LoadOldTransactions(ServiceManager serviceManager)
        {

            List<Transaction> transactionList = serviceManager.transactionService.GetTransactionsList();

            using (var context = new DboTransactionContext())
            {
                transactionList.ForEach((transaction) =>
                {
                    DboTransaction dbotransaction = new DboTransaction
                    {
                        TransactType = transaction.TransactType,
                        Title = transaction.Title,
                        Category = transaction.Category,
                        Date = transaction.Date,
                        Amount = transaction.Amount
                    };
                    context.Transactions.Add(dbotransaction);
                });


                context.SaveChanges();
            }
        }

    }
}
