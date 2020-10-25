namespace BudgetSaverApp.Possessions
{
    public class PossessionFactory
    {
        public static IPosessionsService GetPossessionsService()
        {
            return new PossessionsService();
        }
            
    }
}
