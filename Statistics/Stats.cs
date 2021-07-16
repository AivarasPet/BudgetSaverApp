using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<SubStats> SubStatsList { get; set; }

        public Stats(DateTime startDate, DateTime endDate, ITransactionService transactionService, int userID)
        {
            SubStatsList = new List<SubStats>();
            StartDateTime = startDate;
            EndDateTime = endDate;

            SubStatsList = transactionService.GetTransactionsList(userID)
                           .Where(t => t.Date.Date >= startDate.Date && t.Date.Date <= endDate.Date)
                           .GroupBy(t => new { t.Category, t.TransactType })
                           .Select(t => new SubStats
                           {
                               Category = t.Key.Category,
                               Count = t.Count(),
                               Amount = t.Sum(ta => ta.Amount),
                               IsIncome = (t.Key.TransactType == Transaction.TransactionType.INCOME)
                           }).ToList();

            TransactionAmount = SubStatsList.Count;
            TotalIncome = SubStatsList.Where(x => x.IsIncome).Sum(x => x.Amount);
            TotalExpenses = SubStatsList.Where(x => !x.IsIncome).Sum(x => x.Amount);
        }



    }
}
