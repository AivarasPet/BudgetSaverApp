using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Transactions
{
    class TransactionService
    {
        private List<Transaction> list = new List<Transaction>();
        private static TransactionService _singleton;


        private TransactionService()
        {
            
        }

        public static TransactionService GetTransactionService()
        {
            if (_singleton == null) _singleton = new TransactionService();
            return _singleton;
        }

        public void InitListByStringArray(string[] data)
        {
            if (data == null) return;
           
            for (int x = 0; x < data.Length / 4; x++)
            {
                Transaction transaction = new Transaction(data[4 * x], data[x * 4 + 1], data[x * 4 + 2]); //transactionType, amount, transactionTitle
                list.Add(transaction);
                //Console.WriteLine(transaction.Title);
                //Console.WriteLine(data[4 * x] + x);
            }
        }

        public List<Transaction> GetListWithTitleFiltered(string filter)
        {
            var query = list.Where(oh => oh.Title.ToLower().Contains(filter)).ToList();
            Console.WriteLine(query.Count);
            return query;

        }

        public void LoadTransactionsListFromTextFile()
        {
            ListItemTransactions[] listItems = new ListItemTransactions[20];
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");

            this.InitListByStringArray(data);

        }
        public List<Transaction> GetTransactionsList()
        {
            return list;
        }

        public void AddNewTransaction(string transactionType, string transactionName, string transactionAmount)
        {
            StreamWriter w = File.AppendText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
            if (transactionType   != "" &&
                transactionName   != "" &&
                transactionAmount != "")
            {
                w.WriteLine(transactionType);
                w.WriteLine(transactionName);
                w.WriteLine(transactionAmount);
                w.WriteLine();
                w.Close();
                LoadTransactionsListFromTextFile();
            }
        }

  
    }
}
