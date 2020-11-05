using BudgetSaverApp.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetSaverApp.Statistics
{
    class StatisticsService : IStatisticsService
    {
        ITransactionService transactionService;
        public StatisticsService(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }
        /// <summary>
        /// Returns an instance of Stats with statistics.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Stats GetStatistic(DateTime startDate, DateTime endDate)
        {
            Stats stats = new Stats();

            Console.WriteLine(startDate);
            Console.WriteLine(endDate);
            int amount = 0;
            float income = 0;
            float expenses = 0;
            var result = new Dictionary<string, int>();

            List<Transaction> list = transactionService.GetTransactionsList();
            
            foreach (Transaction t in list)
            {
                if (t == null) continue;

                if (t.Date >= startDate && t.Date <= endDate)
                {
                    amount++;

                    if (t.TransactionType == "Income") income += t.Amount;
                    else expenses += t.Amount;

                    if (result.TryGetValue(t.Category, out int count)) result[t.Category] = count + 1;
                    else result.Add(t.Category, 1);
                }
            }

            stats.TransactionAmount = amount;
            stats.Income = income;
            stats.Expenses = expenses;
            if(result.Count != 0)
                stats.FrequentCategory = result.OrderByDescending(category => category.Value).First().Key;

            return stats;
        }
    }
}
