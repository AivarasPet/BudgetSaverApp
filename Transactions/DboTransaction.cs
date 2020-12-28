using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BudgetSaverApp.Transactions.Transaction;

namespace BudgetSaverApp.Transactions
{
    public class DboTransaction
    {
        public int Id { get; set; }
        public TransactionType TransactType { get; set; }
        public float Amount { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
