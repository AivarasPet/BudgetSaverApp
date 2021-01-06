using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Goals
{
    public interface IGoalsService
    {
        public DataTable GetGoalTable(int userId);
        public DataRow GetUserData(int userId);
        public float GetGoalItemPrice();
        public float GetMonthlySalary();
        public string GetGoalItemName();
        public float GetProfitMonthly();
        public int GetGoalDaysLeft();
        public void SetMainGoalName(string name);
        public void SetMainGoalPrice(float price);
    }
}