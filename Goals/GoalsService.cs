using BudgetSaverApp.Goals;
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
        //string _MainGoalName;
        //float _MainGoalPrice;
        public float GoalItemPrice { get; set; }
        public float CurrentSavings { get; set; }
        public float MonthlySalary { get; set; }
        public string GoalItemName { get; set; }
        public GoalsService(ITransactionService transactionService)
        {
            this._transactionService = transactionService;
            ReadFromFile();
        }

        public DataTable GetGoalTable(int userId)
        {
            using (SqlConnection con = new SqlConnection("Server =.\\SQLEXPRESS; Database = BudgetSaverDatabase; Trusted_Connection = True; "))
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


        public void ReadFromFile()
        {

            TextFileReader textFileReader = new TextFileReader();
            string[] data = textFileReader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\UserData.txt");

            CurrentSavings = float.Parse(data[0]);
            MonthlySalary = float.Parse(data[1]);
            GoalItemName = data[2];
            GoalItemPrice = float.Parse(data[3]);
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

        public Tuple<string, float, float, float, int> GetGoals()
        {           
            string goalName = GetGoalItemName();
            float goalPrice = GetGoalItemPrice();
            float saving = GetMonthlySalary();
            float salary = GetCurrentSavings();
            int goalLeftDays = GetGoalDaysLeft();
            return new Tuple<string, float, float, float, int>(goalName, goalPrice, saving, salary, goalLeftDays);
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

        public void SetMainGoalName(string name)
        {
            GoalItemName = name;
        }

        public void SetMainGoalPrice(float price)
        {
            GoalItemPrice = price;
        }

        
    }
}
