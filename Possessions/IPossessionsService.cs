using BudgetSaverApp.Possessions;
using System.Collections.Generic;

namespace BudgetSaverApp
{
    public interface IPossessionsService 
    {
        public List<Possession> GetPossessionsList();
        public void LoadPossessionsList();
        public float TotalPossessionValue();
        public float TotalPossessionInflation();
    }
}
