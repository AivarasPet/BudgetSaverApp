using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using BudgetSaverApp.Pricing;
using System.IO;



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
            return list ?? null;
        }
     
        public void LoadPossessionsList() {
            
            list.Clear();
            string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Possessions.json");
            if (json == null) return;

            list = JsonConvert.DeserializeObject<List<Possession>>(json);

            foreach (Possession possession in list)
            {
                if (possession == null) continue;
                APIFetcher.AddDownloadEntity(possession.LinkOfAPI, (IApiCallback)possession);
            }
            APIFetcher.RunAllDownloadsAsync();
        }
    }
}
