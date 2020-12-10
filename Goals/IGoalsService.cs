using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Goals
{
    public interface IGoalsService
    {
        public Tuple<string, float, float, float, int> GetGoals();
        public float GetGoalItemPrice();
        public float GetCurrentSavings();
        public float GetMonthlySalary();
        public string GetGoalItemName();
        public float GetProfitMonthly();
        public int GetGoalDaysLeft();
        public void SetMainGoalName(string name);
        public void SetMainGoalPrice(float price);
    }
}