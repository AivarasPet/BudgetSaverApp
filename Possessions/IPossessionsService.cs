using BudgetSaverApp.Possessions;
using System.Collections.Generic;

namespace BudgetSaverApp
{
    public interface IPossessionsService 
    {
        public List<string> GetAllPossessionNames();
        public List<string> GetOwnedPossessionNames();
        public List<Possession> GetPossessionsList();
        public void LoadPossessionsList();
        public void DeletePossession(string possessionName, int userId);
        public void UpdatePossession(string possessionName, float amount, int userId);
        public void InsertPossession(string name, float amount, int userId);//
        public float TotalPossessionValue();
        public float TotalPossessionInflation();
    }
}
