using BudgetSaverApp.Goals;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.Possessions.Links;
using BudgetSaverApp.Transactions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Other
{
    public class DboContext : DbContext
    {
        public DboContext(DbContextOptions options) : base(options) { }
        public DbSet<DboPossession> Possessions { get; set; }
        public DbSet<PossessionAPILink> PossessionsApiLinks { get; set; }
        public DbSet<ImageLink> ImageLinks { get; set; }
        public DbSet<DboTransaction> Transactions { get; set; }
        public DbSet<DboGoal> Goals { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PossessionAPILink>().Property(e => e.Headers).HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, string>>(v));
        }
    }
}
