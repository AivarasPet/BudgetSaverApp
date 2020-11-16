using System;

namespace BudgetSaverApp
{
    public interface ICategoryService
    {
        public string[] GetCategories();
        public void AddCategory(string categoryName);
    }
}
