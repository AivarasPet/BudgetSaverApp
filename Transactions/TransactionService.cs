using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static BudgetSaverApp.Transactions.Transaction;

namespace BudgetSaverApp.Transactions
{
    class TransactionService : ITransactionService
    {
        private List<Transaction> List = new List<Transaction>();

        public List<Transaction> this[DateTime index] {
            get => GetListWithACertainDate(index);
        }

        public event EventHandler OnTransactionServiceLoaded = delegate { }; 
        public TransactionService()
        {
            LoadTransactionsListFromTextFile();
        }


        public List<Transaction> GetListWithTitleFiltered(string filter)
        {
            var query = List.Where(oh => oh.Title.ToLower().Contains(filter)).ToList();
            Console.WriteLine("Query count:" + query.Count);

            return query;
        }

        public void LoadTransactionsListFromTextFile()
        {
            List.Clear();
            string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\TransactionsJson.json");
            if (json == null) return;
            List = JsonConvert.DeserializeObject<List<Transaction>>(json);
            OnTransactionServiceLoaded(null, EventArgs.Empty);
        }

        public void SerializeTransactionList()
        {
            var json = JsonConvert.SerializeObject(List, Formatting.Indented);
            File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\TransactionsJson.json", json);
        }


        public List<Transaction> GetTransactionsList()
        {
            return List ?? null;
        }

        public void AddNewTransaction(TransactionType transactType, string transactionName, string transactionAmount, string category = "Other")
        {
            if (transactionName != "" && transactionAmount != "")
            {
                // Checks whether transaction amount is a number
                float transAmount;
                if (!float.TryParse(transactionAmount, out transAmount))
                    return;

                Transaction newTransaction = new Transaction(transactType, transAmount, transactionName, category, DateTime.Now);

                List.Add(newTransaction);
                SerializeTransactionList();
            }
        }

        private List<Transaction> GetListWithACertainDate(DateTime date)
        {
            return List.Where(oh => oh.Date.Date.CompareTo(date.Date) == 0).ToList(); 
        }

        public List<Tuple<Transaction, int>> GetPopularTransactionTuples()
        {
            List<Tuple<Transaction, int>> tuples = new List<Tuple<Transaction, int>>();
            IList<Transaction> copyOfTransactions = List.Clone();
            for(int x = 0; x < copyOfTransactions.Count; x++)
            {
                int count = 1;
                float amount = (copyOfTransactions.ElementAt(x).TransactType == Transaction.TransactionType.EXPENSES) ? -copyOfTransactions.ElementAt(x).Amount : copyOfTransactions.ElementAt(x).Amount;
                for (int y = x+1; y < copyOfTransactions.Count; y++)
                {
                    if (copyOfTransactions.ElementAt(x).Equals(copyOfTransactions.ElementAt(y)))
                    {
                        count++;
                        amount += (copyOfTransactions.ElementAt(y).TransactType == Transaction.TransactionType.EXPENSES) ? -copyOfTransactions.ElementAt(y).Amount : copyOfTransactions.ElementAt(y).Amount;
                        copyOfTransactions.RemoveAt(y);
                    }
                }
                TransactionType type = (amount >= 0) ? (Transaction.TransactionType.INCOME) : (Transaction.TransactionType.EXPENSES);
                Console.WriteLine("AMOUNT : " + amount);
                Transaction transaction = new Transaction(type, Math.Abs(amount), copyOfTransactions.ElementAt(x).Title, copyOfTransactions.ElementAt(x).Category, copyOfTransactions.ElementAt(x).Date);
                Tuple<Transaction, int> tuple = new Tuple<Transaction, int>(transaction, count);
                if(count > 1) tuples.Add(tuple);
            }
            return tuples;
        }
    }
}

