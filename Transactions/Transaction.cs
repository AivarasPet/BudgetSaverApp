using System;

namespace BudgetSaverApp.Transactions
{
    public class Transaction : IComparable<Transaction>, IEquatable<Transaction>, ICloneable
    {

        [Flags]
        public enum TransactionType
        {
            INCOME = 0,
            EXPENSES = 1
        }
        public TransactionType TransactType { get; }
        public float Amount { get; }
        public string Title { get; }
        public string Category { get; set; }
        public DateTime Date { get; }

        public Transaction(TransactionType transactType, float amount, string title, string category, DateTime date)
        {
            this.TransactType = transactType;
            this.Amount = amount;
            this.Title = title;
            this.Category = category;
            this.Date = date;
        }

        public int CompareTo(Transaction other)
        {
            if (this.Date > other.Date) return 1;
            else if (this.Date < other.Date) return -1;
            else return 0;  
        }

        public bool Equals(Transaction other)
        {
            if(Title == other.Title && Category == other.Category) return true;
            return false;
        }

        public object Clone()
        {
            return new Transaction(TransactType, Amount, Title, Category, Date);
        }
    }
}
