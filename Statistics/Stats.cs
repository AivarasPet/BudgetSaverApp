using System;
using System.Collections.Generic;
using BudgetSaverApp.Transactions;

namespace BudgetSaverApp.Statistics
{
    public class Stats
    {
        public int TransactionAmount { get; set; }
        public float TotalIncome { get; set; }
        public float TotalExpenses { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Dictionary<string, SubStats> SubStatsMap { get; set; }

        public Stats(DateTime startDate, DateTime endDate, ITransactionService transactionService)
        {
            SubStatsMap = new Dictionary<string, SubStats>();
            int amount = 0;
            float income = 0;
            float expenses = 0;
            StartDateTime = startDate;
            EndDateTime = endDate;
            List<Transaction> list = transactionService.GetTransactionsList();

            foreach (Transaction t in list)
            {
                if (t == null) continue;

                if (t.Date >= startDate && t.Date <= endDate)
                {
                    amount++;

                    if (this.SubStatsMap.TryGetValue(t.Category, out SubStats subStats))
                    {
                        subStats.Count++;
                        ProcessSubStats(subStats, t, ref income, ref expenses);
                    }
                    else
                    {
                        SubStats newSubStats = new SubStats { Count = 1 };
                        this.SubStatsMap.Add(t.Category, newSubStats);
                        ProcessSubStats(newSubStats, t, ref income, ref expenses);
                    }
                }
            }

            TransactionAmount = amount;
            TotalIncome = income;
            TotalExpenses = expenses;
            //if(result.Count != 0)
            //    stats.FrequentCategory = result.OrderByDescending(category => category.Value).First().Key;
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
