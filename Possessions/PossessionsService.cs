using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using BudgetSaverApp.Pricing;

namespace BudgetSaverApp.Possessions
{
    public class PossessionsService
    {
        List<Possession> list = new List<Possession>();

        private static PossessionsService _singleton;


        private PossessionsService()
        {

        }

        public List<Possession> GetPossessionsList()
        {
            return list;
        }

        public static PossessionsService GetPossessionsService()
        {
            if (_singleton == null) _singleton = new PossessionsService();
            return _singleton;
        }

        public void LoadPossessionsListFromTextFile() {
            list.Clear();
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Possessions.txt");
            if (data == null) return;

            for (int x = 0; x < data.Length; x++)
            {
                if (data[x] == "") continue;

                int posOfSepperator = data[x].IndexOf(':');
                string possessionType = data[x].Substring(0, posOfSepperator);
                string jsonObjStr = data[x].Substring(posOfSepperator + 1, data[x].Length - possessionType.Length - 2);
                
                JObject o = JObject.Parse(jsonObjStr);

                Possession possession = possessionType switch
                {
                    "Crypto" => new Crypto(),
                    "Commodity" => new Commodity(),
                    "Stock" => new Stock(),
                    _ => null
                };


                if (possession != null)
                {
                    JsonConvert.PopulateObject(jsonObjStr, possession);
                    Console.WriteLine(possession.name);
                    list.Add(possession);
                    APIFetcher.AddDownloadEntity(possession.linkOfAPI, (IHasAPI) possession); //downloads its api
                }
            }

            APIFetcher.RunAllDownloadsAsync();
        }

            
    }
}
