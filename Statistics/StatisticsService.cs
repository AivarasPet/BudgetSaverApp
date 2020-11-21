using BudgetSaverApp.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetSaverApp.Statistics
{
    class StatisticsService : IStatisticsService
    {
        ITransactionService transactionService;
        List<Stats> StatsPastYearMonthly;
        Stats StatsLastMonth, StatsPastYear;


        public StatisticsService(ITransactionService transactionService)
        {
            this.transactionService = transactionService;

            
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            StatsLastMonth = GetStatistic(firstDayOfMonth, lastDayOfMonth);
            StatsPastYearMonthly = new List<Stats>();
            StatsPastYear = GetStatistic(firstDayOfMonth.AddYears(-1), lastDayOfMonth);

            for (int x = 0; x < 12; x++)
            {
                Stats stat = GetStatistic(firstDayOfMonth, lastDayOfMonth);
                StatsPastYearMonthly.Add(stat);
                firstDayOfMonth = firstDayOfMonth.AddMonths(-1);
                lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            }
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



        public Dictionary<string, Stats> LowestYearlyExpenesByCategory(Stats statsToBeCommpared)
        {
            Dictionary<string, Stats> dict = new Dictionary<string, Stats>();
            foreach (string key in statsToBeCommpared.SubStatsMap.Keys)
            {
                var query = (from c in StatsPastYearMonthly
                             where c.SubStatsMap.ContainsKey(key)
                             orderby c.SubStatsMap[key].Expenses ascending
                             select c
                            ).Take(1);
                dict.Add(key, query.ElementAt(0));
            }

            return dict;
        }

        public Dictionary<string, Stats> HighestYearlyIncomeByCategory(Stats statsToBeCompared)
        {
            Dictionary<string, Stats> dict = new Dictionary<string, Stats>();
            foreach (string key in statsToBeCompared.SubStatsMap.Keys)
            {
                var query = (from c in StatsPastYearMonthly
                             where c.SubStatsMap.ContainsKey(key)
                             orderby c.SubStatsMap[key].Income descending
                             select c
                            ).Take(1);
                dict.Add(key, query.ElementAt(0));
            }

            return dict;
        }

        public List<string> Suggestions()
        {
            List<string> toReturn = new List<string>();
            
            Dictionary<string, Stats> dict = new Dictionary<string, Stats>();
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            var lastMonthStats = GetStatistic(firstDayOfMonth, lastDayOfMonth);

            Dictionary<string, Stats> lowestInYearStats = LowestYearlyExpenesByCategory(lastMonthStats);

            foreach (string key in lastMonthStats.SubStatsMap.Keys)
            {
                if (key.Equals("N/A")) continue;
                if(lowestInYearStats.TryGetValue(key, out Stats value))
                {
                    float oldExpenses = value.SubStatsMap[key].Expenses;
                    float newExpenses = lastMonthStats.SubStatsMap[key].Expenses;
                    string message =
                        (oldExpenses > newExpenses)
                            ? ("this month You spent " + (oldExpenses - newExpenses) + " Eur. more than you ever have on " + key)
                            : ("this month You spent " + (newExpenses - oldExpenses) + " Eur. less than you ever have on " + key);
                    toReturn.Add(message);
                }
            }
            return toReturn;
        }
    }
}
