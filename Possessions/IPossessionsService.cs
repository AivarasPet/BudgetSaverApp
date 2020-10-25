using BudgetSaverApp.Possessions;
using System.Collections.Generic;

namespace BudgetSaverApp
{
    public interface IPosessionsService 
    {
        public List<Possession> GetPossessionsList();
        public void LoadPossessionsList();
    }
}
