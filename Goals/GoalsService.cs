using BudgetSaverApp.Goals;
using BudgetSaverApp.Other;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.UserData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BudgetSaverApp.Portfolio
{
    public class GoalsService : IGoalsService
    {
        ITransactionService _transactionService;
        private DboContext _DboContext;
        private string connectionString;
        //string _MainGoalName;
        //float _MainGoalPrice;
        public float GoalItemPrice { get; set; }
        public float CurrentSavings { get; set; }
        public float MonthlySalary { get; set; }
        public string GoalItemName { get; set; }
        public GoalsService(ITransactionService transactionService, DboContext dboContext) //, ConnectionStringHelper connectionStringHelper
        {
            connectionString = "Server =.\\SQLEXPRESS; Database = BudgetSaverDatabase; Trusted_Connection = True;";
            _DboContext = dboContext;
            this._transactionService = transactionService;
            ReadFromFile();
        }

        public DataTable GetGoalTable(int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Goals WHERE UserId = @userId", con);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt;
            }
            
        }

        public DataRow GetUserData(int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CurrentSavings, MonthlySalary FROM dbo.Users WHERE Id = @userId", con);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt.Rows[0];
            }
        }

        public void ReadFromFile()
        {

            TextFileReader textFileReader = new TextFileReader();
            string[] data = textFileReader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\UserData.txt");

            CurrentSavings = float.Parse(data[0]);
            MonthlySalary = float.Parse(data[1]);
        }

        public float GetProfitMonthly(int userID)
        {
            Stats StatsRecent30Days = new Stats(DateTime.Now - TimeSpan.FromDays(30), DateTime.Now, _transactionService, userID);
            return StatsRecent30Days.TotalIncome - StatsRecent30Days.TotalExpenses;
        }

        public int GetGoalDaysLeft(int userID)
        {
            return (int) getGoalDays(GoalItemPrice, GetProfitMonthly(userID).Daily());
        }

        Func<float, float, float> getGoalDays = (a, b) => a / b;

        public float GetGoalItemPrice()
        {
            return GoalItemPrice;
        }

        public float GetMonthlySalary()
        {
            return MonthlySalary;
        }

        public string GetGoalItemName()
        {
            return GoalItemName;
        }

        public void SetMainGoalName(string name)
        {
            GoalItemName = name;
        }

        public void SetMainGoalPrice(float price)
        {
            GoalItemPrice = price;
        }

        public void AddNewGoal(string inputName, float inputAmount, string inputDescription, int userId)
        {
            if (inputName != "" && inputDescription != "")
            {
                // Checks whether transaction amount is a number

                if (inputAmount < 0)
                    throw new ArgumentException("Provided amount can't be negative");

                DboGoal newTransaction = new DboGoal();

                DboGoal dboGoal = new DboGoal
                {
                    GoalItemName = inputName,
                    GoalItemPrice = inputAmount,
                    GoalDescription = inputDescription,
                    UserId = userId
                };
                _DboContext.Goals.Add(dboGoal);
                _DboContext.SaveChanges();

            }
        }

        public void UpdateGoal(string inputName, float inputAmount, string inputDescription, int goalId, int userId)
        {
            var x = _DboContext.Goals.Where(x => x.UserId == userId && x.Id == goalId).FirstOrDefault();
            x.GoalItemName = inputName;
            x.GoalItemPrice = inputAmount;
            x.GoalDescription = inputDescription;
            _DboContext.SaveChanges();
        }

        public void DeleteGoal(int goalId, int userId)
        {
            var x = _DboContext.Goals.Where(x => x.UserId == userId && x.Id == goalId).FirstOrDefault();
            if (x == null) return;
            _DboContext.Goals.Remove(_DboContext.Goals.Find(goalId));
            _DboContext.SaveChanges();            
        }

        public int GetGoalDaysLeft()
        {
            throw new NotImplementedException();
        }

        public List<DboGoal> GetUserGoals(int userId)
        {
            List<DboGoal> list = _DboContext.Goals.Where(x => x.UserId == userId).OrderByDescending(y => y.GoalItemPrice).ToList();
            return list;
        }
    }
}
