using BudgetSaverApp.Transactions;
using System;
using System.Collections.Generic;
using static BudgetSaverApp.Transactions.Transaction;

namespace BudgetSaverApp
{
    public interface ITransactionService
    {
        public List<Transaction> GetListWithTitleFiltered(string filter);
        public void LoadTransactionsListFromTextFile();
        
        public void LoadTransactionsListFromDatabase();
        public List<Transaction> GetTransactionsList();
        
        public void AddNewTransaction(TransactionType transactType, string transactionName, string transactionAmount, string category = "N/A");

        public List<Tuple<Transaction, int>> GetPopularTransactionTuples();
         
        public delegate void TransactionAddedEventHandler(object source, Transaction args);
        public event TransactionAddedEventHandler TransactionAdded;
        List<Transaction> this[DateTime index] { get;}
    }
}
