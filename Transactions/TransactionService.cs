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
using Newtonsoft.Json;

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

        /*public void InitListByStringArray(string[] data)
        {
            if (data == null) return;
           
            for (int x = 0; x < data.Length / 4; x++)
            {
                Transaction transaction = new Transaction(data[4 * x], data[x * 4 + 1], data[x * 4 + 2], data[x * 4 + 3]); //transactionType, amount, transactionTitle
                list.Add(transaction);
                //Console.WriteLine(transaction.Title);
                //Console.WriteLine(data[4 * x] + x);
            }
        }*/

        public List<Transaction> GetListWithTitleFiltered(string filter)
        {
            var query = list.Where(oh => oh.Title.ToLower().Contains(filter)).ToList();
            Console.WriteLine("Query count:" + query.Count);
            return query;

        }

        public void LoadTransactionsListFromTextFile()
        {
            list.Clear();
            ListItemTransactions[] listItems = new ListItemTransactions[20];
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
            if(list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
            
        }

        public void AddNewTransaction(string transactionType, string transactionName, string transactionAmount, string category)
        {
            
            if (transactionType != "" && transactionName != "" && transactionAmount != "")
            {
                if (category == "") { category = "Default"; }
                Transaction newTransaction = new Transaction(transactionType, float.Parse(transactionAmount), transactionName, category); 
                list.Add(newTransaction);
                StreamWriter w = File.AppendText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Transactions.txt");
                w.WriteLine(JsonConvert.SerializeObject(newTransaction));
                w.Close();
            }
            
            

            //LoadTransactionsListFromTextFile();

        }


    }
}

