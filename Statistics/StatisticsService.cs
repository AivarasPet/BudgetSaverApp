using BudgetSaverApp.Transactions;
using my_new_app.ModelsToBeFetched;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetSaverApp.Statistics
{
    public class StatisticsService : IStatisticsService
    {
   
        ITransactionService transactionService;
        List<Stats> StatsPastYearMonthly;
        Lazy<Stats> StatsLastMonth;
        Lazy<Stats> StatsPastYear;


        public StatisticsService(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
            transactionService.TransactionAdded += OnTransactionAdded;

            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            StatsLastMonth = new Lazy<Stats>( () => new Stats(new DateTime(date.Year, date.Month, 1).AddMonths(-1), new DateTime(date.Year, date.Month, 1).AddDays(-1), transactionService));
            StatsPastYear = new Lazy<Stats>( () => new Stats(firstDayOfMonth.AddYears(-1), lastDayOfMonth, transactionService));

            StatsPastYearMonthly = new List<Stats>();
            for (int x = 0; x < 12; x++)
            {
                Stats stat = new Stats(firstDayOfMonth, lastDayOfMonth, transactionService);
                StatsPastYearMonthly.Add(stat);
                firstDayOfMonth = firstDayOfMonth.AddMonths(-1);
                lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            }
        }


        void OnTransactionAdded(object sender, Transaction added)
        {
            //StatsLastMonth.Value.TransactionAmount++;
            //bool isExpense = added.TransactType == Transaction.TransactionType.EXPENSES;
            //if (isExpense)
            //    StatsLastMonth.Value.TotalExpenses += added.Amount;
            //else
            //    StatsLastMonth.Value.TotalIncome += added.Amount;
            //if (StatsLastMonth.Value.SubStatsMap.Contains(added.Category, out SubStats value))
            //{
            //    value.Count++;
            //    if (isExpense) value.Expenses += added.Amount;
            //    else value.Income += added.Amount;
            //}
            //else StatsLastMonth.Value.SubStatsMap.Add(added.Category, value);
        }

        //public Dictionary<string, Stats> LowestYearlyExpenesByCategory(Stats statsToBeCompared)
        //{
        //    if (StatsPastYearMonthly.Contains(statsToBeCompared)) StatsPastYearMonthly.Remove(statsToBeCompared);
        //    Dictionary<string, Stats> dict = new Dictionary<string, Stats>();
        //    foreach (string key in statsToBeCompared.SubStatsList.Select(x => x.Category))
        //    {
        //        var query = (from c in StatsPastYearMonthly.SubStatsList.Where(x => x.Category == key)
        //                     orderby c.SubStatsMap[key].Expenses ascending
        //                     select c
        //                    ).Take(1);
        //        dict.Add(key, query.ElementAt(0));
        //    }

        //    return dict;
        //}

        //public Dictionary<string, Stats> HighestYearlyIncomeByCategory(Stats statsToBeCompared)
        //{
        //    Dictionary<string, Stats> dict = new Dictionary<string, Stats>();
        //    if (StatsPastYearMonthly.Contains(statsToBeCompared)) StatsPastYearMonthly.Remove(statsToBeCompared);
        //    foreach (string key in statsToBeCompared.SubStatsMap.Keys)
        //    {
        //        var query = (from c in StatsPastYearMonthly
        //                     where c.SubStatsMap.ContainsKey(key)
        //                     orderby c.SubStatsMap[key].Income descending
        //                     select c
        //                    ).Take(1);
        //        dict.Add(key, query.ElementAt(0));
        //    }

        //    return dict;
        //}


 

        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategory(DateTime monthComparedTo)
        {
            StatsLastMonth.Value.TotalIncome += 0;
            Stats statsThatAreCompared = StatsLastMonth.Value;
            while (StatsLastMonth.Value == null) { }
            List<FinancialFeedbackByCategory> toReturn = new List<FinancialFeedbackByCategory>();
            var firstDayOfComparedMonth = new DateTime(monthComparedTo.Year, monthComparedTo.Month, 1);
            var lastDayOfComparedMonth = firstDayOfComparedMonth.AddMonths(1).AddDays(-1);
            Stats statsThatAreComparedTo = new Stats(firstDayOfComparedMonth, lastDayOfComparedMonth, transactionService);
            float oldExpenses, newExpenses;

            String date1 = statsThatAreComparedTo.StartDateTime.ToString("yyyy-MM-dd");
            String date2 = statsThatAreCompared.StartDateTime.ToString("yyyy-MM-dd");

            List<FinancialFeedbackByCategory> list =
                (from sc in statsThatAreCompared.SubStatsList
                 join sct in statsThatAreComparedTo.SubStatsList
                 on sc.Category equals sct.Category
                 select new FinancialFeedbackByCategory
                 {
                     Category = sc.Category,
                     IsExpenses = !sc.IsIncome,
                     DateCompared = statsThatAreCompared.StartDateTime,
                     DateComparedTo = statsThatAreComparedTo.StartDateTime,
                     Difference = Math.Abs(sc.Amount - sct.Amount) ,
                     PercentageDifference = Math.Abs((sct.Amount - sc.Amount) / (sct.Amount) * 100),
                     IsFeedbackPositive = (sc.Amount >= sct.Amount && sc.IsIncome || sc.Amount < sct.Amount && !sc.IsIncome),
                     FormatedDateTo = date1,
                     FormatedDate = date2
                 }).ToList();

            return list;
        }

        //public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryAdvanced()
        //{
        //    Stats statsThatAreCompared = StatsLastMonth.Value;
        //    while(StatsLastMonth.Value == null) { }
        //    List<FinancialFeedbackByCategory> toReturn = new List<FinancialFeedbackByCategory>();
        //    Dictionary<string, Stats> dictLowestExpenses = LowestYearlyExpenesByCategory(statsThatAreCompared);
        //    Dictionary<string, Stats> dictHighestIncome = HighestYearlyIncomeByCategory(statsThatAreCompared);

        //    foreach (string key in statsThatAreCompared.SubStatsMap.Keys)
        //    {
        //        if (dictLowestExpenses.TryGetValue(key, out Stats value))
        //        {
        //            float oldExpenses = value.SubStatsMap[key].Expenses;
        //            float newExpenses = statsThatAreCompared.SubStatsMap[key].Expenses;
        //            if (oldExpenses != newExpenses) toReturn.Add(FinancialFeedbackBuilder(false, oldExpenses, newExpenses, statsThatAreCompared.StartDateTime, value.StartDateTime, key));
        //        }
        //    }

        //    foreach (string key in statsThatAreCompared.SubStatsMap.Keys)
        //    {
        //        if (dictLowestExpenses.TryGetValue(key, out Stats value))
        //        {
        //            float oldIncome = value.SubStatsMap[key].Income;
        //            float newIncome = statsThatAreCompared.SubStatsMap[key].Income;
        //            if (oldIncome != newIncome) toReturn.Add(FinancialFeedbackBuilder(true, oldIncome, newIncome, statsThatAreCompared.StartDateTime, value.StartDateTime, key));
        //        }
        //    }

        //    return toReturn;
        //}

        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryPreviousMonth()
        {
            DateTime date = DateTime.Now;
            var prev = date.AddMonths(-2);
            return GetFinancialFeedackByCategory(prev);
        }
    }
}