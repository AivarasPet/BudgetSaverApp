using BudgetSaverApp.Possessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public interface IPosessionsService 
    {
        public List<Possession> GetPossessionsList();
        public void LoadPossessionsList();
    }
}
