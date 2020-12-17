using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BudgetSaverApp.Possessions.Links;

namespace BudgetSaverApp.Possessions
{
    class DboPossessionContext : DbContext
    {
        public DbSet<DboPossession> Possessions { get; set; }
        public DbSet<ApiLink> ApiLinks { get; set; }
        public DbSet<ImageLink> ImageLinks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
