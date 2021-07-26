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
        public void DeletePossession(int possessionId, int userId);
        public void UpdatePossession(int possessionId, float amount, int userId);
        public void InsertPossession(int possessionId, float amount, int userId);//
        public FloatObj TotalPossessionValue(int userId);
        public float TotalPossessionInflation(int userId);
    }
}
