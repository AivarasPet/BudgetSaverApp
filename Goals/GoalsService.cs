using BudgetSaverApp.Goals;
using BudgetSaverApp.Other;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.UserData;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BudgetSaverApp.Portfolio
{
    public class GoalsService : IGoalsService
    {
        ITransactionService _transactionService;
        private DboContext _dboContext;
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
            _dboContext = dboContext;
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

        public float GetProfitMonthly()
        {
            Stats StatsRecent30Days = new Stats(DateTime.Now - TimeSpan.FromDays(30), DateTime.Now, _transactionService);
            return StatsRecent30Days.TotalIncome - StatsRecent30Days.TotalExpenses;
        }

        public int GetGoalDaysLeft()
        {
            return (int) getGoalDays(GoalItemPrice, GetProfitMonthly().Daily());
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
                _dboContext.Goals.Add(dboGoal);
                _dboContext.SaveChanges();

            }
        }

        public void UpdateGoal(string inputName, float inputAmount, string inputDescription, int goalId, int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Goals WHERE UserId = @userId", con);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string hehe = dt.Rows[goalId]["Id"].ToString();

                sda.UpdateCommand = new SqlCommand("UPDATE dbo.Goals SET GoalItemName = @goalItemName, GoalItemPrice = @goalItemPrice, GoalDescription = @goalDescription WHERE Id = @goalId", con);

                sda.UpdateCommand.Parameters.Add(new SqlParameter("@goalId", hehe));
                sda.UpdateCommand.Parameters.Add(new SqlParameter("@goalItemName", inputName));
                sda.UpdateCommand.Parameters.Add(new SqlParameter("@goalDescription", inputDescription));
                sda.UpdateCommand.Parameters.Add(new SqlParameter("@goalItemPrice", inputAmount));

                DataRow goalRow = dt.Rows[goalId];
                goalRow["GoalItemName"] = inputName;
                goalRow["GoalItemPrice"] = inputAmount;
                goalRow["GoalDescription"] = inputDescription;

                sda.Update(dt);

                /*
                SqlCommand updateCmd = new SqlCommand("UPDATE dbo.Goals SET GoalItemName = @goalItemName, GoalItemPrice = @goalItemPrice, GoalDescription = @goalDescription WHERE Id = @goalId", con);
                updateCmd.Parameters.Add(new SqlParameter("@goalId", hehe));
                updateCmd.Parameters.Add(new SqlParameter("@goalItemName", inputName));
                updateCmd.Parameters.Add(new SqlParameter("@goalDescription", inputDescription));
                updateCmd.Parameters.Add(new SqlParameter("@goalItemPrice", inputAmount));

                try
                {
                    updateCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }*/
                con.Close();
            }
        }

        public void DeleteGoal(int goalId, int userId)
        {
            string hehe;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Goals WHERE UserId = @userId", con);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                hehe = dt.Rows[goalId]["Id"].ToString();
            }

            try
            {
                _dboContext.Goals.Remove(_dboContext.Goals.Find(Int32.Parse(hehe)));
                _dboContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
