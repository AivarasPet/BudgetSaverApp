using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public class UserData
    {
        private float currentSavings;
        private float monthlySalary;
        private string goalItemName;
        private float goalItemPrice;

        public UserData()
        {
            ReadFromFile();
        }
        //Setters
        public void SetGoalName(string name)
        {
            goalItemName = name;
        }

        public void SetGoalPrice(float price)
        {
            goalItemPrice = price;
        }

        public void SetSavings(float savings)
        {
            currentSavings = savings;
        }

        public void SetMonthlySalary(float salary)
        {
            monthlySalary = salary;
        }

        public void SetAll(string name, float price, float savings, float salary)
        {
            goalItemName = name;
            goalItemPrice = price;
            currentSavings = savings;
            monthlySalary = salary;
        }

        //Getters
        public string GetGoalName()
        {
            return goalItemName;
        }

        public float GetGoalPrice()
        {
            return goalItemPrice;
        }

        public float GetSavings()
        {
            return currentSavings;
        }

        public float GetMonthlySalary()
        {
            return monthlySalary;
        }

        //IO
        public void SaveToFile()
        {
            StreamWriter writer = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
            writer.WriteLine(currentSavings);
            writer.WriteLine(monthlySalary);
            writer.WriteLine(goalItemName);
            writer.WriteLine(goalItemPrice);
            writer.Close();
        }

        public void ReadFromFile()
        {
            TextFileReader textFileReader = new TextFileReader();
            string[] data = textFileReader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");

            currentSavings = float.Parse(data[0]);
            monthlySalary = float.Parse(data[1]);
            goalItemName = data[2];
            goalItemPrice = float.Parse(data[3]);
        }


    }
}
