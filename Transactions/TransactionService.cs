﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static BudgetSaverApp.Transactions.Transaction;
using System.Configuration;

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

                if(transAmount < 0)
                    throw new ArgumentException("Provided amount can't be negative");
                
                // Check if category exists

                ICategoryService categoryService = new CategoryService();
                string [] categories = categoryService.GetCategories();
                bool exists = false;
                foreach(string cat in categories)
                {
                    if(category == cat)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    throw new BadCategoryException("Category not found");
                }
                

                Transaction newTransaction = new Transaction(transactType, transAmount, transactionName, category, DateTime.Now);

                List.Add(newTransaction);
                SerializeTransactionList();
            }
        }

        private List<Transaction> GetListWithACertainDate(DateTime date)
        {
            return List.Where(oh => oh.Date.Date.CompareTo(date.Date) == 0).ToList(); 
        }

        public delegate float Converter(Transaction element);

        public List<Tuple<Transaction, int>> GetPopularTransactionTuples()
        {
            Converter convertAmount = delegate (Transaction element)
            {
                return (element.TransactType == Transaction.TransactionType.EXPENSES) ? -element.Amount : element.Amount;
            };

            List<Tuple<Transaction, int>> tuples = new List<Tuple<Transaction, int>>();
            IList<Transaction> copyOfTransactions = List.Clone();
            for(int x = 0; x < copyOfTransactions.Count; x++)
            {
                int count = 1;
                float amount = convertAmount(copyOfTransactions.ElementAt(x));
                for (int y = x+1; y < copyOfTransactions.Count; y++)
                {
                    if (copyOfTransactions.ElementAt(x).Equals(copyOfTransactions.ElementAt(y)))
                    {
                        count++;
                        amount += convertAmount(copyOfTransactions.ElementAt(y));
                        copyOfTransactions.RemoveAt(y);
                    }
                }
                TransactionType type = (amount >= 0) ? (Transaction.TransactionType.INCOME) : (Transaction.TransactionType.EXPENSES);
                Transaction transaction = new Transaction(type, Math.Abs(amount), copyOfTransactions.ElementAt(x).Title, copyOfTransactions.ElementAt(x).Category, copyOfTransactions.ElementAt(x).Date);
                Tuple<Transaction, int> tuple = new Tuple<Transaction, int>(transaction, count);
                if(count > 1) tuples.Add(tuple);
            }
            return tuples;
        }

        public string CheckPopularTransaction(string value)
        {
            string key = ConfigurationManager.AppSettings["APIKeyInflation"];
            if (value == key) return "true"; else return "false";
        }
    }
}

