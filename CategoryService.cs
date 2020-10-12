using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BudgetSaverApp
{
    class CategoryService
    {

        private static CategoryService _singleton;

        public static CategoryService GetTransactionService()
        {
            if (_singleton == null) _singleton = new CategoryService();
            return _singleton;
        }

        public string[] GetCategories()
        {
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Categories.txt");
            if (data == null) return null;
            string[] categories = new string[data.Length];
            for (int x = 0; x < data.Length; x++)
            {
                categories[x] = data[x].ToString();
            }
            return categories;
        }

        

    }
}
