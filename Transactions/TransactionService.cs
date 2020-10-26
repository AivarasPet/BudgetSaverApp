using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

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
            string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\TransactionsJson.json");
            if (json == null) return;
            List = JsonConvert.DeserializeObject<List<Transaction>>(json);
            OnTransactionServiceLoaded(null, EventArgs.Empty);
        }

        public void SerializeTransactionList()
        {
            var json = JsonConvert.SerializeObject(List, Formatting.Indented);
            File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\TransactionsJson.json", json);
        }


        public List<Transaction> GetTransactionsList()
        {
            return List ?? null;
        }

        public void AddNewTransaction(string transactionType, string transactionName, string transactionAmount, string category = "N/A")
        {
            if (transactionType != "" && transactionName != "" && transactionAmount != "")
            {
                // Checks whether transaction amount is a number
                float transAmount;
                if (!float.TryParse(transactionAmount, out transAmount))
                    return;

                Transaction newTransaction = new Transaction(transactionType, transAmount, transactionName, category, DateTime.Now); 
                List.Add(newTransaction);
                SerializeTransactionList();
            }
        }

        private List<Transaction> GetListWithACertainDate(DateTime date)
        {
            return List.Where(oh => oh.Date.Equals(date.Date)).ToList(); ;
        }
    }
}

