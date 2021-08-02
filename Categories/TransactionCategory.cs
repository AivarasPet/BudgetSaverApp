using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Categories
{
    public class TransactionCategory
    {
        public int Id { get; set; }
        public int CategoryType { get; set; } //0 - income, 1- expense
        public string Name { get; set; }
        public int UserID { get; set; }
    }
}
