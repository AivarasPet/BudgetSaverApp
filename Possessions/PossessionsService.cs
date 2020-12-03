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
            string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\Possessions.json");
            

            if (json == null) return;

            list = JsonConvert.DeserializeObject<List<Possession>>(json);

            string apiJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\APILinks.json");
            string imageJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\ImageLinks.json");

            List<ApiLink> apiList = JsonConvert.DeserializeObject<List<ApiLink>>(apiJson);
            List<ImageLink> imageList = JsonConvert.DeserializeObject<List<ImageLink>>(imageJson);

            //var completeList = list.GroupJoin(apiList, a => a.ApiLinkID, b => b.Id, (item, api) => new
            // {
            //     Item = item,
            //     Api = api
            // });          
            var completeList =
                from a in apiList
                join l in list
                on a.Id equals l.ApiLinkID
                select new {Item = l, Link = a.Link, Type = a.Type, Headers = a.Headers};

            List<Possession> list1 = new List<Possession>();

            foreach(var item in completeList)
            {              
                Possession possession = item.Item;
                possession.Type = item.Type;
                ApiLink apiLink = new ApiLink
                {
                    Headers = item.Headers,
                    Link = item.Link,
                    Type = item.Type
                };                
                APIFetcher.AddDownloadEntity(apiLink, (IApiCallback) item.Item);
            }

            var completeList2 = list.GroupJoin(imageList, a => a.LinkOfImage, b => b.id, (item, api) => new
            {
                Item = item,
                Api = api
            });

            foreach (var item in completeList2)
            {

                Possession possession = item.Item;

                try
                {
                    possession.LinkOfImage = item.Api.First().link;
                }
                catch (Exception e)
                {
                    Console.WriteLine("API was not found for Possession: " + possession.Name);
                }                

                list1.Add(possession);
            }

            list = list1;

            APIFetcher.RunAllDownloadsAsync();
        }
    }
}
