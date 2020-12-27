using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetSaverApp.Possessions.Links;
using Microsoft.EntityFrameworkCore;

namespace BudgetSaverApp.Possessions
{
    public class DboPossessionContext : DbContext
    {
        public DbSet<DboPossession> Possessions { get; set; }
        public DbSet<ApiLink> ApiLinks { get; set; }
        public DbSet<ImageLink> ImageLinks { get; set; }

    }
}
