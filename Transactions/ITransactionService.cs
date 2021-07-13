using BudgetSaverApp.Transactions;
using System;
using System.Collections.Generic;
using static BudgetSaverApp.Transactions.Transaction;

namespace BudgetSaverApp
{
    public interface ITransactionService
    {
        public List<Transaction> GetListWithTitleFiltered(string filter, int userID);
        public void LoadTransactionsListFromTextFile();
        
        public void LoadTransactionsListFromDatabase();
        public List<Transaction> GetTransactionsList(int userID);
        
        public void AddNewTransaction(TransactionType transactType, string transactionName, string transactionAmount, int userID, string category = "N/A");

        public List<Tuple<Transaction, int>> GetPopularTransactionTuples(int userID);
         
        public delegate void TransactionAddedEventHandler(object source, Transaction args);
        public event TransactionAddedEventHandler TransactionAdded;
        List<Transaction> this[DateTime index] { get;}
    }
}
