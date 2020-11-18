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

            List<Transaction> list = transactionService.GetTransactionsList();

            foreach (Transaction t in list)
            {
                if (t == null) continue;

                if (t.Date >= startDate && t.Date <= endDate)
                {
                    amount++;

                    if (stats.SubStatsMap.TryGetValue(t.Category, out SubStats subStats))
                    {
                        subStats.Count++;
                        ProcessSubStats(subStats, t, ref income, ref expenses);
                    }
                    else
                    {
                        SubStats newSubStats = new SubStats { Count = 1};
                        stats.SubStatsMap.Add(t.Category, newSubStats);
                        ProcessSubStats(newSubStats, t, ref income, ref expenses);
                    }
                }
            }

            stats.TransactionAmount = amount;
            stats.TotalIncome = income;
            stats.TotalExpenses = expenses;
            //if(result.Count != 0)
            //    stats.FrequentCategory = result.OrderByDescending(category => category.Value).First().Key;

            return stats;
        }

        private void ProcessSubStats(SubStats subStats, Transaction transaction, ref float totalIncome, ref float totalExpenses)
        {
            if (transaction.TransactType == Transaction.TransactionType.INCOME)
            {
                subStats.Income += transaction.Amount;
                totalIncome += transaction.Amount;
            }
            else
            {
                subStats.Expenses += transaction.Amount;
                totalExpenses += transaction.Amount;
            }
        }
    }
}
