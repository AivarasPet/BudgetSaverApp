using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static BudgetSaverApp.Transactions.Transaction;
using System.Configuration;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using BudgetSaverApp.Other;
using BudgetSaverApp.Categories;

namespace BudgetSaverApp.Transactions
{
    public class TransactionAddedEventArgs : EventArgs
    {
        public Transaction transaction{ get; set; }
    }
public class TransactionService : ITransactionService
    {
        private DboContext _dboContext;
        private ICategoryService _CategoryService;
        //private UserDataService _userDataService;
        Mapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DboTransaction, Transaction>()));

        public List<Transaction> this[DateTime index] => throw new NotImplementedException();

        public TransactionService(DboContext dboContext, ICategoryService categoryService) //, UserDataService userDataService
        {
            _dboContext = dboContext;
            _CategoryService = categoryService;
            //_userDataService = userDataService;
            LoadTransactionsListFromDatabase();
        }
        
        //private List<Transaction> List = new List<Transaction>();

        //public List<Transaction> this[DateTime index] {
        //    get => GetListWithACertainDate(index);
        //}

        public event EventHandler OnTransactionServiceLoaded = delegate { }; 

        private event ITransactionService.TransactionAddedEventHandler TransactionAdded;

        event ITransactionService.TransactionAddedEventHandler ITransactionService.TransactionAdded
        {
            add
            {
                TransactionAdded += value;
            }

            remove
            {
                TransactionAdded -= value;
            }
        }

        public List<Transaction> GetListWithTitleFiltered(string filter, int userID)
        {
            var query = _dboContext.Transactions.Where(x => x.UserId == userID).Where(oh => oh.Title.ToLower().Contains(filter)).ToList();
            return mapper.Map<List<Transaction>>(query);
        }

        public void LoadTransactionsListFromTextFile()
        {
            //List.Clear();
            //string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\TransactionsJson.json");
            //if (json == null) return;
            //List = JsonConvert.DeserializeObject<List<Transaction>>(json);
            //OnTransactionServiceLoaded(null, EventArgs.Empty);
        }


        public void LoadTransactionsListFromDatabase()
        {
            //List.Clear();
            
            //var query = from transaction in _dboContext.Transactions
            //            orderby transaction.Date
            //            select transaction;
            ////Transaction transaction = new Transaction(dboTransaction.TransactType,dboTransaction.Amount,dboTransaction.Title,dboTransaction.Category,dboTransaction.Date);

            //var config = new MapperConfiguration(cfg => cfg.CreateMap<DboTransaction, Transaction>());
            //var mapper = new Mapper(config);
            //List = mapper.Map<List<Transaction>>(query);

            //OnTransactionServiceLoaded(null, EventArgs.Empty);
        
        } 

        public void SerializeTransactionList()
        {
            //var json = JsonConvert.SerializeObject(List, Formatting.Indented);
            //File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\TransactionsJson.json", json);
        }


        public List<Transaction> GetTransactionsList(int userID)
        {
            var query = _dboContext.Transactions.Where(x => x.UserId == userID).OrderByDescending(x => x.Date).ToList();
            return mapper.Map<List<Transaction>>(query);
        }


        private List<Transaction> GetListWithACertainDate(DateTime date, int userID)
        {
            var query = _dboContext.Transactions.Where(x => x.UserId == userID).Where(oh => oh.Date.Date.CompareTo(date.Date) == 0).ToList(); 
            return mapper.Map<List<Transaction>>(query);
        }

        public delegate T Converter<T>(Transaction element);

        public List<Tuple<Transaction, int>> GetPopularTransactionTuples(int userID)
        {
            var query = _dboContext.Transactions.Where(x => x.UserId == userID);
            var tuples = mapper.Map<List<Transaction>>(query).GroupBy(l => l.Title)
            .Select(cl => new Tuple<Transaction, int>(cl.First(), cl.Count()))
            .Where(kk => kk.Item2 > 1)
            .OrderBy(oo => oo.Item2)
            .ToList();

            return tuples;
        }


        protected virtual void OnTransactionAdded(Transaction transaction)
        {

            if (TransactionAdded != null)
                TransactionAdded(this, transaction);

        }

        public void AddNewTransaction(TransactionType transactType, string transactionName, string transactionAmount, DateTime date, int userID, string category = "N/A")
        {

            if (transactionName != "" && transactionAmount != "")
            {
                // Checks whether transaction amount is a number
                float transAmount;

                if (!float.TryParse(transactionAmount, out transAmount))
                    return;

                if (transAmount < 0)
                    throw new ArgumentException("Provided amount can't be negative");

                // Check if category exists

                TransactionCategoriesMeshed categories = _CategoryService.GetTransactionCategories();
                if (!categories.IncomeCategories.Exists(x => x.Name == category) && !categories.ExpensesCategories.Exists(x => x.Name == category))
                {
                    throw new BadCategoryException("Category not found: ", category);
                }

                //Transaction newTransaction = new Transaction(transactType, transAmount, transactionName, category, DateTime.Now);

                //List.Add(newTransaction);
                //OnTransactionAdded(newTransaction);

                DboTransaction dbotransaction = new DboTransaction
                {
                    TransactType = transactType,
                    Title = transactionName,
                    Category = category,
                    Date = (date == null) ? DateTime.Now : date,
                    Amount = transAmount,
                    UserId = userID
                };
                _dboContext.Transactions.Add(dbotransaction);
                _dboContext.SaveChanges();

                //SerializeTransactionList();
            }
        }
    }
}

