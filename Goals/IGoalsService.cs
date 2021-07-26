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
        public List<DboGoal> GetUserGoals(int userId);
        public DataRow GetUserData(int userId);
        public void UpdateGoal(string inputName, float inputAmount, string inputDescription, int goalId, int userId);
        public void AddNewGoal(string inputName, float inputAmount, string inputDescription, int userId);
        public void DeleteGoal(int goalId,int userId);
        public float GetGoalItemPrice();
        public float GetMonthlySalary();
        public string GetGoalItemName();
        public float GetProfitMonthly(int userID);
        public int GetGoalDaysLeft();
        public void SetMainGoalName(string name);
        public void SetMainGoalPrice(float price);
    }
}