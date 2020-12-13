using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Transactions
{
    public class DboTransactionsRepository
    {
        public List<DboTransaction> GetTransactions() 
        {
            DboTransactionsContext transactionsContext = new DboTransactionsContext();
            return transactionsContext.DboTransactions.ToList();
        }
    }
}
