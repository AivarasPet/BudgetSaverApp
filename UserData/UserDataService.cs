using BudgetSaverApp.Goals;
using BudgetSaverApp.Portfolio;
using BudgetSaverApp.UserData;
using System.IO;

namespace BudgetSaverApp
{
    class UserDataService : IUserDataService
    {
        public float GoalItemPrice { get; set; }
        public float CurrentSavings { get; set; }
        public float MonthlySalary { get; set; }
        public string GoalItemName { get; set; }

        IGoalsService GoalsService;
        public UserDataService(IGoalsService goalsService)
        {
            this.GoalsService = goalsService;
            ReadFromFile();
        }

        public void SetAll(string name, float price, float savings, float salary)
        {
            GoalItemName = name;
            GoalItemPrice = price;
            CurrentSavings = savings;
            MonthlySalary = salary;
        }

        /// <summary>
        /// Saves user data to Data\UserData.txt.
        /// </summary>
        public void SaveToFile()
        {
            StreamWriter writer = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
            writer.WriteLine(CurrentSavings);
            writer.WriteLine(MonthlySalary);
            writer.WriteLine(GoalItemName);
            writer.WriteLine(GoalItemPrice);
            writer.Close();
        }
        /// <summary>
        /// Reads data from Data\UserData.txt and saves it to variables.
        /// </summary>
        public void ReadFromFile()
        {
            TextFileReader textFileReader = new TextFileReader();
            string[] data = textFileReader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");

            CurrentSavings = float.Parse(data[0]);
            MonthlySalary = float.Parse(data[1]);
            GoalItemName = data[2];
            GoalItemPrice = float.Parse(data[3]);
            GoalsService.SetMainGoalName(GoalItemName);
            GoalsService.SetMainGoalPrice(GoalItemPrice);
        }

        public float GetGoalItemPrice()
        {
            return GoalItemPrice;
        }

        public float GetCurrentSavings()
        {
            return CurrentSavings;
        }

        public float GetMonthlySalary()
        {
            return MonthlySalary;
        }

        public string GetGoalItemName()
        {
            return GoalItemName;
        }
    }
}
