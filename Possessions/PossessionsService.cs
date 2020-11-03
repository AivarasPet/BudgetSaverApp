using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using BudgetSaverApp.Pricing;
using System.IO;
using BudgetSaverApp.Possessions.Links;
using System.Linq;

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

            string apiJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\APILinks.json");
            string imageJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\ImageLinks.json");

            GenericLinkList<ApiLink> apiList = JsonConvert.DeserializeObject<GenericLinkList<ApiLink>>(apiJson);
            
            GenericLinkList<ImageLink> imageList = JsonConvert.DeserializeObject<GenericLinkList<ImageLink>>(imageJson);


            var completeList = list.GroupJoin(apiList, a => a.LinkOfAPI, b => b.id, (item, api) => new
            {
                Item = item,
                Api = api
            });

            List<Possession> list1 = new List<Possession>();

            foreach(var item in completeList)
            {
                Possession possession = item.Item;
                possession.LinkOfAPI = item.Api.First().link;
                list1.Add(possession);
            }

            var completeList2 = list.GroupJoin(imageList, a => a.LinkOfImage, b => b.id, (item, api) => new
            {
                Item = item,
                Api = api
            });

            list = list1;

            foreach (var item in list)
            {
                foreach(var itemImage in completeList2)
                {
                    if(item.LinkOfImage == itemImage.Item.LinkOfImage)
                    {
                        item.LinkOfImage = itemImage.Api.First().link;
                    }
                }
            }

            foreach (Possession possession in list)
            {
                Console.WriteLine(possession.Name);
                Console.WriteLine(possession.LinkOfAPI);
                Console.WriteLine(possession.LinkOfImage);
            }

            foreach (Possession possession in list)
            {
                if (possession == null) continue;
                APIFetcher.AddDownloadEntity(possession.LinkOfAPI, (IApiCallback)possession);
            }

            

            

            APIFetcher.RunAllDownloadsAsync();
        }
    }
}
