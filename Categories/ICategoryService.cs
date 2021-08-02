using BudgetSaverApp.Categories;
using System;

namespace BudgetSaverApp
{
    public interface ICategoryService
    {
        public TransactionCategoriesMeshed GetTransactionCategories();
        public void AddCategory(string categoryName);
    }
}
