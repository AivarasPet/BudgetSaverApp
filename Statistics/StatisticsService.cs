using BudgetSaverApp.Transactions;
using my_new_app.ModelsToBeFetched;
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
                        SubStats newSubStats = new SubStats { Count = 1 };
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



        public Dictionary<string, Stats> LowestYearlyExpenesByCategory(Stats statsToBeCompared)
        {
            if (StatsPastYearMonthly.Contains(statsToBeCompared)) StatsPastYearMonthly.Remove(statsToBeCompared);
            Dictionary<string, Stats> dict = new Dictionary<string, Stats>();
            foreach (string key in statsToBeCompared.SubStatsMap.Keys)
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
            if (StatsPastYearMonthly.Contains(statsToBeCompared)) StatsPastYearMonthly.Remove(statsToBeCompared);
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


        private FinancialFeedbackByCategory FinancialFeedbackBuilder(bool isIncome, float oldNumber, float newNumber, DateTime dateCompared, DateTime dateComparedTo, string categpry)
        {
            float difference, percentage;
            bool isPositiveFeedback;

            if(oldNumber < newNumber)
            {
                difference = newNumber - oldNumber;
                percentage = difference / (oldNumber + difference) * 100;
                isPositiveFeedback = !isIncome;
            }
            else
            {
                difference = oldNumber - newNumber;
                percentage = difference / (newNumber + difference) * 100;
                isPositiveFeedback = isIncome;
            }

            return new FinancialFeedbackByCategory
            {
                category = categpry,
                IsExpenses = !isIncome,
                IsFeedbackPositive = isPositiveFeedback,
                DateCompared = dateCompared,
                DateComparedTo = dateComparedTo,
                Difference = difference,
                PercentageDifference = percentage
            };
        }

 

        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategory(DateTime monthComparedTo)
        {
            Stats statsThatAreCompared = StatsLastMonth;
            List<FinancialFeedbackByCategory> toReturn = new List<FinancialFeedbackByCategory>();
            var firstDayOfComparedMonth = new DateTime(monthComparedTo.Year, monthComparedTo.Month, 1);
            var lastDayOfComparedMonth = firstDayOfComparedMonth.AddMonths(1).AddDays(-1);
            Stats statsThatAreComparedTo = this.GetStatistic(firstDayOfComparedMonth, lastDayOfComparedMonth);
            float oldExpenses, newExpenses;

            foreach (string key in statsThatAreCompared.SubStatsMap.Keys)
            {
                if (key.Equals("N/A")) continue;
                if (statsThatAreComparedTo.SubStatsMap.TryGetValue(key, out SubStats value))
                {
                    oldExpenses = value.Expenses;
                    newExpenses = statsThatAreCompared.SubStatsMap[key].Expenses;
                }
                else
                {
                    oldExpenses = 0;
                    newExpenses = 0;
                }
                   
                if (oldExpenses != newExpenses) toReturn.Add(FinancialFeedbackBuilder(false, oldExpenses, newExpenses, statsThatAreCompared.StartDateTime, firstDayOfComparedMonth, key));
            }
            float oldIncome =0, newIncome =0;
            foreach (string key in statsThatAreCompared.SubStatsMap.Keys)
            {
                if (key.Equals("N/A")) continue;
                if (statsThatAreComparedTo.SubStatsMap.TryGetValue(key, out SubStats value))
                {
                    oldIncome = value.Income;
                    newIncome = statsThatAreCompared.SubStatsMap[key].Income;
                }
                else
                {
                    oldExpenses = 0;
                    newExpenses = 0;
                }
                if (oldIncome != newIncome) toReturn.Add(FinancialFeedbackBuilder(true, oldIncome, newIncome, statsThatAreCompared.StartDateTime, firstDayOfComparedMonth, key));
            }

            return toReturn;
        }

        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryAdvanced()
        {
            Stats statsThatAreCompared = StatsLastMonth;
            List<FinancialFeedbackByCategory> toReturn = new List<FinancialFeedbackByCategory>();
            Dictionary<string, Stats> dictLowestExpenses = LowestYearlyExpenesByCategory(statsThatAreCompared);
            Dictionary<string, Stats> dictHighestIncome = HighestYearlyIncomeByCategory(statsThatAreCompared);

            foreach (string key in statsThatAreCompared.SubStatsMap.Keys)
            {
                if (key.Equals("N/A")) continue;
                if (dictLowestExpenses.TryGetValue(key, out Stats value))
                {
                    float oldExpenses = value.SubStatsMap[key].Expenses;
                    float newExpenses = statsThatAreCompared.SubStatsMap[key].Expenses;
                    if (oldExpenses != newExpenses) toReturn.Add(FinancialFeedbackBuilder(false, oldExpenses, newExpenses, statsThatAreCompared.StartDateTime, value.StartDateTime, key));
                }
            }

            foreach (string key in statsThatAreCompared.SubStatsMap.Keys)
            {
                if (key.Equals("N/A")) continue;
                if (dictLowestExpenses.TryGetValue(key, out Stats value))
                {
                    float oldIncome = value.SubStatsMap[key].Income;
                    float newIncome = statsThatAreCompared.SubStatsMap[key].Income;
                    if (oldIncome != newIncome) toReturn.Add(FinancialFeedbackBuilder(true, oldIncome, newIncome, statsThatAreCompared.StartDateTime, value.StartDateTime, key));
                }
            }

            return toReturn;
        }

        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryPreviousMonth()
        {
            DateTime date = DateTime.Now;
            var prev = date.AddMonths(-2);
            return GetFinancialFeedackByCategory(prev);
        }
    }
}