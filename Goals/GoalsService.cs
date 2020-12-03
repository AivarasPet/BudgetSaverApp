using BudgetSaverApp.Goals;
using BudgetSaverApp.Statistics;
using System;

namespace BudgetSaverApp.Portfolio
{
    class GoalsService : IGoalsService
    {
        ITransactionService _transactionService;
        string _MainGoalName;
        float _MainGoalPrice;

        public  GoalsService(ITransactionService transactionService )
        {
            this._transactionService = transactionService;
            
        }

        public float GetProfitMonthly()
        {
            Stats StatsRecent30Days = new Stats(DateTime.Now - TimeSpan.FromDays(30), DateTime.Now, _transactionService);
            return StatsRecent30Days.TotalIncome - StatsRecent30Days.TotalExpenses;
        }

        public int GetGoalDaysLeft()
        {
            return (int) getGoalDays(_MainGoalPrice, GetProfitMonthly().Daily());
            //return (int)(_MainGoalPrice / GetProfitMonthly().Daily());
        }

        Func<float, float, float> getGoalDays = (a, b) => a / b;

        public string MainGoalName()
        {
            return _MainGoalName;
        }

        public float MainGoalPrice()
        {
            return _MainGoalPrice;
        }


        public void SetMainGoalName(string name)
        {
            _MainGoalName = name;
        }

        public void SetMainGoalPrice(float price)
        {
            _MainGoalPrice = price;
        }
    }
}
