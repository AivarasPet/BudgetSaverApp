using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using BudgetSaverApp.Pricing;

namespace BudgetSaverApp.Possessions
{
    class PossessionsService : IPosessionsService
    {
        List<Possession> list = new List<Possession>();

        public PossessionsService()
        {
            LoadPossessionsList();
        }

        public List<Possession> GetPossessionsList()
        {
            return list;
        }
     
        public void LoadPossessionsList() {
            list.Clear();
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Possessions.txt");
            if (data == null) return;

            for (int x = 0; x < data.Length; x++)
            {
                if (data[x] == "") continue;


                JObject o = JObject.Parse(data[x]);

                Possession possession = o["Type"].ToString() switch
                {
                    "Crypto" => new Crypto(),
                    "Commodity" => new Commodity(),
                    "Stock" => new Stock(),
                    _ => null
                };


                if (possession != null)
                {
                    JsonConvert.PopulateObject(o["Object"].ToString(), possession);
                    Console.WriteLine(possession.Name);
                    list.Add(possession);
                    APIFetcher.AddDownloadEntity(possession.LinkOfAPI, (IApiCallback) possession); //downloads its api
                }
            }

            APIFetcher.RunAllDownloadsAsync();
        }
    }
}
