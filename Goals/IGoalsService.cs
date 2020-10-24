using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Goals
{
    public interface IGoalsService
    {
        public String MainGoalName();
        public float MainGoalPrice();

        public float GetProfitMonthly();

        public int GetGoalDaysLeft();

        public void SetMainGoalName(string name);
        public void SetMainGoalPrice(float price);
    }
}