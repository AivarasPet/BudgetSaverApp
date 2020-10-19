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
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
            if (data == null) return;
            for (int x = 0; x < data.Length; x++)
            {
                Transaction transaction = JsonConvert.DeserializeObject<Transaction>(data[x]);
                if(transaction != null)
                {
                    List.Add(transaction);
                }
            }
            OnTransactionServiceLoaded(null, EventArgs.Empty);
        }
        public List<Transaction> GetTransactionsList()
        {
            return List ?? null;
        }

        public void AddNewTransaction(string transactionType, string transactionName, string transactionAmount, string category)
        {
            if (transactionType != "" && transactionName != "" && transactionAmount != "")
            {
                if (category == "") { category = "Default"; }

                // Checks whether transaction amount is a number
                float transAmount;
                if (!float.TryParse(transactionAmount, out transAmount))
                    return;

                Transaction newTransaction = new Transaction(transactionType, transAmount, transactionName, category, DateTime.Now); 
                List.Add(newTransaction);
                StreamWriter w = File.AppendText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
                w.WriteLine(JsonConvert.SerializeObject(newTransaction));
                w.Close();
            }
        }
    }
}

