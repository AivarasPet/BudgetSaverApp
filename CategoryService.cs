using System.IO;

namespace BudgetSaverApp
{
    class CategoryService
    {

        private static CategoryService _singleton;

        public static CategoryService GetCategoryService()
        {
            if (_singleton == null) _singleton = new CategoryService();
            return _singleton;
        }

        /// <summary>
        /// Returns a string array of transaction categories from Data\Categories.txt.
        /// </summary>
        /// <returns></returns>
        public string[] GetCategories()
        {
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Categories.txt");
            if (data == null) return null;
            string[] categories = new string[data.Length-1];
            for (int x = 0; x < data.Length; x++)
            {
                if (data[x] == "") continue;

                categories[x] = data[x].ToString();
            }
            return categories;
        }

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
    }
}
