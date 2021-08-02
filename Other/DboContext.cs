using BudgetSaverApp.Categories;
using BudgetSaverApp.Goals;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Possessions.Links;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.UserData;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BudgetSaverApp.CategoryService;

namespace BudgetSaverApp.Other
{
    public class DboContext : DbContext
    {
        public DboContext(DbContextOptions options) : base(options) { }
        public DbSet<DboPossession> Possessions { get; set; }
        public DbSet<DboPossessionData> PossessionsData { get; set; }
        public DbSet<DboTransaction> Transactions { get; set; }
        public DbSet<DboGoal> Goals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TransactionCategory> TransactionCategories {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DboPossessionData>().Property(e => e.Headers).HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, string>>(v));
        }
    }
}
