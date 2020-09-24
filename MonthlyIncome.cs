using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    class MonthlyIncome
    {
        private int uGoal;
        public int RemainingMonthsToWork(int salary, int budget, int goal)
        {
            int remainingMonths = 0;
            uGoal = goal-budget;
            if ((uGoal) > 0)
            {
                while (uGoal > 0)
                {
                    uGoal -= salary;
                    remainingMonths++;
                }
            }
            return remainingMonths;
        }
    }
}
