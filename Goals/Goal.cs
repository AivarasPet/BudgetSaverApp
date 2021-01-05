using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Goals
{
    public class Goal
    {
        public string GoalItemName { get; set; }
        public float GoalItemPrice { get; set; }
        public string GoalDescription { get; set; }
        public int GoalUserId { get; set; }
        
    }
}
