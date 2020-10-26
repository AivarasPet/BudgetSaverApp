using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.UserData
{
    public interface IUserDataService
    {
        public void SetAll(string name, float price, float savings, float salary);
        public void SaveToFile();
        public void ReadFromFile();

        public float GetGoalItemPrice();
        public float GetCurrentSavings();
        public float GetMonthlySalary();
        public string GetGoalItemName();
    }
}
