using System;

namespace BudgetSaverApp.Transactions
{
    public class Transaction
    {
        public string TransactionType { get;}
        public float Amount { get; }
        public string Title { get; }
        public string Category { get; set; }


        public Transaction(string transactionType, float amount, string title, string category)
        {
            

            this.TransactionType = transactionType;
            this.Title = title;
            this.Amount = amount;
            this.Category = category;
        }

        public void writeAmount()
        {
            Console.WriteLine(this.Amount);
        }

        //public abstract void AbstractMethod();   // Abstract method
    
        //public abstract int Y { get; }
    }
}
