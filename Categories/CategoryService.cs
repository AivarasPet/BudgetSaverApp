using BudgetSaverApp.Categories;
using BudgetSaverApp.Other;
using System.IO;
using System.Linq;

namespace BudgetSaverApp
{
    public class CategoryService : ICategoryService
    {
        DboContext _DboContext;
        public CategoryService(DboContext dboContext)
        {
            _DboContext = dboContext;
        }
        /// <summary>
        /// Returns a string array of transaction categories from Data\Categories.txt.
        /// </summary>
        /// <returns></returns>
        //public string[] GetCategories()
        //{
        //    TextFileReader reader = new TextFileReader();
        //    string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\Categories.txt");
        //    if (data == null) return null;
        //    string[] categories = new string[data.Length-1];
        //    for (int x = 0; x < data.Length; x++)
        //    {
        //        if (data[x] == "") continue;

        //        categories[x] = data[x].Substring(0,data[x].Length-1);

        //    }
        //    return categories;
        //}

        /// <summary>
        /// Adds a transaction category to Data\Categories.txt.
        /// </summary>
        /// <param name="categoryName">Name of the new category.</param>
        public void AddCategory(string categoryName)
        {
            if (categoryName == null) return;
            StreamWriter w = File.AppendText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Categories.txt");
            w.WriteLine(categoryName);
            w.Close();
        }

        public TransactionCategoriesMeshed GetTransactionCategories()
        {
            var whatToReturn = new TransactionCategoriesMeshed
            {
                IncomeCategories = _DboContext.TransactionCategories.Where(x => x.CategoryType == 0).ToList(),
                ExpensesCategories = _DboContext.TransactionCategories.Where(x => x.CategoryType == 1).ToList()
            };
            return whatToReturn;
        }
    }
}
