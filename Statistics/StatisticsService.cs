﻿using BudgetSaverApp.Possessions;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.UserData;
using my_new_app.ModelsToBeFetched;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetSaverApp.Statistics
{
    public class StatisticsService : IStatisticsService
    {
   
        ITransactionService _TransactionService;
        IUserIDService _UserIDService;
        List<Stats> StatsPastYearMonthly;
        Lazy<Stats> StatsLastMonth;
        Lazy<Stats> StatsPastYear;


        public StatisticsService(ITransactionService transactionService, IUserIDService userIDService, PossessionDataHolder possessionDataHolder)
        {
            _TransactionService = transactionService;
            _UserIDService = userIDService;
            //possessionDataHolder.Activate();
            //transactionService.TransactionAdded += OnTransactionAdded;
            //int userID = userIDService.GetUserID();
            //DateTime date = DateTime.Now;
            //var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            //var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            ////StatsLastMonth = new Lazy<Stats>( () => new Stats(new DateTime(date.Year, date.Month, 1).AddMonths(-1), new DateTime(date.Year, date.Month, 1).AddDays(-1), transactionService, userID));
            //StatsPastYear = new Lazy<Stats>( () => new Stats(firstDayOfMonth.AddYears(-1), lastDayOfMonth, transactionService, userID));

            //StatsPastYearMonthly = new List<Stats>();
            //for (int x = 0; x < 12; x++)
            //{
            //    Stats stat = new Stats(firstDayOfMonth, lastDayOfMonth, transactionService, userID);
            //    StatsPastYearMonthly.Add(stat);
            //    firstDayOfMonth = firstDayOfMonth.AddMonths(-1);
            //    lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            //}
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

        //public List<SubStats>  LowestYearlyExpenesByCategory(Stats statsToBeCompared)
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
        public struct SubStatsWithDate {
            public DateTime Date;
            public SubStats Sub;
        }

        List<SubStatsWithDate> getSub(Stats stats, DateTime time)
        {
            List<SubStatsWithDate> subStatsList = new List<SubStatsWithDate>();
            stats.SubStatsList.Where(x => x.IsIncome).ToList().ForEach(x => subStatsList.Add(new SubStatsWithDate { Sub = x, Date = time }));
            return subStatsList;
        }

  

        //public List<TopEarningsMonthlyByCategory> HighestMonthlyIncomeByCategory()
        //{
        //    List<List<SubStatsWithDate>> list = new List<List<SubStatsWithDate>>();
        //    StatsPastYearMonthly.ForEach(x => list.Add(getSub(x, x.StartDateTime)));

        //    var query = list.Aggregate((before, next) => {
        //        var x = from sc in before
        //                join sct in next
        //                on sc.Sub.Category equals sct.Sub.Category
        //                orderby sc.Sub.Amount descending
        //                select new SubStatsWithDate{Sub = new SubStats{Category = sc.Sub.Category, Amount = Math.Max(sc.Sub.Amount, sct.Sub.Amount) },
        //                Date = (sc.Sub.Amount>sct.Sub.Amount) ? sc.Date : sct.Date
        //                };
        //        return x.ToList();
        //   });

        //    return query.Take(3).Select(x => new TopEarningsMonthlyByCategory { Amount = x.Sub.Amount, Category = x.Sub.Category, Month = x.Date.Month.ToString("MMMM") }).ToList();
        //}


        public string GetTopEarnings(int userID) {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            Stats stats = new Stats(firstDayOfMonth.AddYears(-1), lastDayOfMonth, _TransactionService, userID);
            var xx = stats.SubStatsList.Where(s => s.IsIncome).OrderBy(x => x.Amount).Select(x => x.Category).Take(3);
            var x = stats.SubStatsList.Where(s => s.IsIncome).OrderBy(x => x.Amount).Select(x => x.Category).Take(3).Aggregate("", (x, y) => { return x + ", " + y; }).Skip(1);
            return string.Concat(x);
        }



        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategory(DateTime monthComparedTo, int userID)
        {
            DateTime date = DateTime.Now;
            Stats statsThatAreCompared = new Stats(
                 new DateTime(date.Year, date.Month, 1)
                ,new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1)
                ,_TransactionService
                , userID
            );
            var firstDayOfComparedMonth = new DateTime(monthComparedTo.Year, monthComparedTo.Month, 1);
            var lastDayOfComparedMonth = firstDayOfComparedMonth.AddMonths(1).AddDays(-1);
            Stats statsThatAreComparedTo = new Stats(firstDayOfComparedMonth, lastDayOfComparedMonth, _TransactionService, userID);


            List<FinancialFeedbackByCategory> toReturn = new List<FinancialFeedbackByCategory>();
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
                     IsFeedbackPositive = (sc.Amount >= sct.Amount && sc.IsIncome || sc.Amount < sct.Amount && !sc.IsIncome)
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

        public List<FinancialFeedbackByCategory> GetFinancialFeedackByCategoryPreviousMonth(int userID)
        {
            DateTime date = DateTime.Now;
            var prev = new DateTime(date.Year, date.Month-1, 1);
            return GetFinancialFeedackByCategory(prev, userID);
        }

        public float DailyProfit(int userID)
        {
            List<Transaction> transactions= _TransactionService.GetTransactionsList(userID);
            if (transactions.Count < 1) return 0;
            DateTime date1 = transactions.OrderBy(x => x.Date).FirstOrDefault().Date;
            DateTime date2 = transactions.OrderByDescending(x => x.Date).FirstOrDefault().Date;
            double daysDiff = date2.Subtract(date1).TotalDays;
            Stats stats = new Stats(date1, date2, _TransactionService, userID);
            return ((stats.TotalIncome-stats.TotalExpenses)/(float)daysDiff);
        }
    }
}