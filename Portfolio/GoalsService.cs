﻿namespace BudgetSaverApp.Portfolio
{
    class GoalsService
    {
        public static float mainGoalPrice { get; set; }
        public static float salaryMonthly { get; set; }
        public static float currentSavings { get; set; }
        public static string mainGoalName { get; set; }

        public GoalsService()
        {
            LoadDataFromTextFile();
        }

        public void LoadDataFromTextFile()
        {
            TextFileReader textFileReader = new TextFileReader();
            string[] data = textFileReader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");

            currentSavings = float.Parse(data[0]);
            salaryMonthly = float.Parse(data[1]);
            mainGoalName = data[2];
            mainGoalPrice = float.Parse(data[3]);
        }
    }
}