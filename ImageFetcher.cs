using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public class ImageFetcher
    {
        private static Dictionary<string, string> hashMap = new Dictionary<string, string>();

        public static void InitImageLinks()
        {
            hashMap.Clear();
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\ImageLinks.txt");
            if (data == null) return;

            for (int x = 0; x < data.Length; x++)
            {
                if (data[x] == "") continue;

                int posOfSepperator = data[x].IndexOf(':');
                string key = data[x].Substring(0, posOfSepperator);
                string link = data[x].Substring(posOfSepperator + 1, data[x].Length - key.Length - 2);

                hashMap.Add(key, link);
            }
        }

        public static string GetImageLink(string key)
        {
            return hashMap[key];
        }
    }
}
