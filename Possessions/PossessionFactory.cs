namespace BudgetSaverApp.Possessions
{
    public class PossessionFactory
    {
        public static IPossessionsService GetPossessionsService()
        {
            return new PossessionsService();
        }
            
    }
}
