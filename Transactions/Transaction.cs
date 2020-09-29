using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Transactions
{
    public class Transaction
    {
        public string TransactionType { get;}
        public float Amount { get; }
        public string Title { get; }

        public Transaction(string transactionType,  string title, string amountStr)
        {
            this.TransactionType = transactionType;
            this.Title = title;
            Amount = float.Parse(amountStr);
        }


        //public abstract void AbstractMethod();   // Abstract method
    
        //public abstract int Y { get; }
    }
}
