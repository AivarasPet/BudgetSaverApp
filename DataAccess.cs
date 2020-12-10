using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetSaverApp.Transactions;
using Dapper;

namespace BudgetSaverApp
{
    class DataAccess
    {
        public List<Transaction> GetTransactions()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
            {
                return connection.Query<Transaction>($"SELECT * FROM Transactions").ToList();
            }
        }
    }
}
