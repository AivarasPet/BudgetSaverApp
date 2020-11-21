using System;
using System.Collections.Generic;

namespace BudgetSaverApp.Statistics
{
    public class Stats
    {
        public int TransactionAmount { get; set; }
        public float TotalIncome { get; set; }
        public float TotalExpenses { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Dictionary<string, SubStats> SubStatsMap = new Dictionary<string, SubStats>();
    }
}
