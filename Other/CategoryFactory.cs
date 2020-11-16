namespace BudgetSaverApp
{
    public class CategoryFactory
    {
        public static ICategoryService GetStatisticsService()
        {
            return new CategoryService();
        }
    }
}
