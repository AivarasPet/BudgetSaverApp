using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace BudgetSaverApp.Transactions
{
    class TransactionService
    {
        private List<Transaction> list = new List<Transaction>();
        private static TransactionService _singleton;

        public static TransactionService GetTransactionService()
        {
            if (_singleton == null) _singleton = new TransactionService();
            return _singleton;
        }

        public List<Transaction> GetListWithTitleFiltered(string filter)
        {
            var query = list.Where(oh => oh.Title.ToLower().Contains(filter)).ToList();
            Console.WriteLine("Query count:" + query.Count);

            return query;
        }

        public void LoadTransactionsListFromTextFile()
        {
            list.Clear();
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
            if (data == null) return;
            for (int x = 0; x < data.Length; x++)
            {
                Transaction transaction = JsonConvert.DeserializeObject<Transaction>(data[x]);
                if(transaction != null)
                {
                    list.Add(transaction);
                }
            }
        }
        public List<Transaction> GetTransactionsList()
        {
            return list ?? null;
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

                Transaction newTransaction = new Transaction(transactionType, transAmount, transactionName, category); 
                list.Add(newTransaction);
                StreamWriter w = File.AppendText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
                w.WriteLine(JsonConvert.SerializeObject(newTransaction));
                w.Close();
            }
        }
    }
}

