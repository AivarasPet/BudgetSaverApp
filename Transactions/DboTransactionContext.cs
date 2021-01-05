using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Transactions
{
    public class DboTransactionContext : DbContext
    {

        public DbSet<DboTransaction> Transactions { get; set; }
        public DboTransactionContext(DbContextOptions<DboTransactionContext> options) : base(options)
        {

        }
    }
}
