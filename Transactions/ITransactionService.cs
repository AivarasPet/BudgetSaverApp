using BudgetSaverApp.Transactions;
using System.Collections.Generic;

namespace BudgetSaverApp
{
    public interface ITransactionService
    {
        public List<Transaction> GetListWithTitleFiltered(string filter);
        public void LoadTransactionsListFromTextFile();
        public List<Transaction> GetTransactionsList();
        public void AddNewTransaction(string transactionType, string transactionName, string transactionAmount, string category);
    }
}
