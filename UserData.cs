﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public class UserData
    {
        public float GoalItemPrice { get; set; }
        public float CurrentSavings { get; set; }
        public float MonthlySalary { get; set; }
        public string GoalItemName { get; set; }
        public UserData()
        {
            ReadFromFile();
        }

        public void SetAll(string name, float price, float savings, float salary)
        {
            GoalItemName = name;
            GoalItemPrice = price;
            CurrentSavings = savings;
            MonthlySalary = salary;
        }

        //IO
        public void SaveToFile()
        {
            StreamWriter writer = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");
            writer.WriteLine(CurrentSavings);
            writer.WriteLine(MonthlySalary);
            writer.WriteLine(GoalItemName);
            writer.WriteLine(GoalItemPrice);
            writer.Close();
        }

        public void ReadFromFile()
        {
            TextFileReader textFileReader = new TextFileReader();
            string[] data = textFileReader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\UserData.txt");

            CurrentSavings = float.Parse(data[0]);
            MonthlySalary = float.Parse(data[1]);
            GoalItemName = data[2];
            GoalItemPrice = float.Parse(data[3]);
        }


    }
}