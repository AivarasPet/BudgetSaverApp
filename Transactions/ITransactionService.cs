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
        public List<Transaction> GetTransactionsList();
        public void AddNewTransaction(TransactionType transactType, string transactionName, string transactionAmount, string category = "N/A");

        public List<Tuple<Transaction, int>> GetPopularTransactionTuples();
        List<Transaction> this[DateTime index] { get;}
        public string CheckPopularTransaction(string value);
    }
}
