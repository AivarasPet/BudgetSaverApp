using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Transactions
{
    public class TransactionsFactory
    {
        public static ITransactionService GetTransactionService()
        {
            return new TransactionService();
        }
    }
}
