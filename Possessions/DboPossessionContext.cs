using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetSaverApp.Possessions.Links;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BudgetSaverApp.Possessions
{

    public class DboPossessionContext : DbContext
    {
        public DboPossessionContext(DbContextOptions options) : base(options) { }
        public DbSet<DboPossession> Possessions { get; set; }
        public DbSet<ApiLink> ApiLinks { get; set; }
        public DbSet<ImageLink> ImageLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApiLink>().Property(e => e.Headers).HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, string>>(v));
        }
    }
}
