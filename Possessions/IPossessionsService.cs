using BudgetSaverApp.Possessions;
using System.Collections.Generic;

namespace BudgetSaverApp
{
    public class FloatObj
    {
        public float Float { get; set; }
    }
    public interface IPossessionsService 
    {
        public List<string> GetAllPossessionNames(int userId);
        public List<string> GetOwnedPossessionNames(int userId);
        public List<Possession> GetPossessionsList(int userID);
        public void DeletePossession(string possessionName, int userId);
        public void UpdatePossession(string possessionName, float amount, int userId);
        public void InsertPossession(string possessionName, float amount, int userId);//
        public FloatObj TotalPossessionValue(int userId);
        public float TotalPossessionInflation(int userId);
    }
}
