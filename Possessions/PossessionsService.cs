using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using BudgetSaverApp.Pricing;
using System.IO;
using BudgetSaverApp.Possessions.Links;
using System.Linq;
using AutoMapper;

namespace BudgetSaverApp.Possessions
{
    
    public class PossessionsService : IPossessionsService
    {
        List<Possession> List = new List<Possession>();

        public PossessionsService()
        {
            LoadPossessionsListFile();
        }

        public List<Possession> GetPossessionsList()
        {
            return List ?? null;
        }

     
        public void LoadPossessionsListFile() {
            List.Clear();
            string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\Possessions.json");
            
            if (json == null) return;

            List = JsonConvert.DeserializeObject<List<Possession>>(json);
            
            string apiJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\APILinks.json");
            string imageJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\ImageLinks.json");

            List<ApiLink> apiList = JsonConvert.DeserializeObject<List<ApiLink>>(apiJson);
            List<ImageLink> imageList = JsonConvert.DeserializeObject<List<ImageLink>>(imageJson);

            var completeList =
                from a in apiList
                join l in List
                on a.Id equals l.ApiLinkID
                select new {Item = l, Link = a.Url, Type = a.Type, Headers = a.Headers};

            List<Possession> list1 = new List<Possession>();

            foreach(var item in completeList)
            {              
                Possession possession = item.Item;
                possession.Type = item.Type;
                ApiLink apiLink = new ApiLink
                {
                    Headers = item.Headers,
                    Url = item.Link,
                    Type = item.Type
                };                
                APIFetcher.AddDownloadEntity(apiLink, (IApiCallback) item.Item);
            }

            var completeList2 = List.GroupJoin(imageList, a => a.LinkOfImageID, b => b.id, (item, api) => new
            {
                Item = item,
                Api = api
            });

            foreach (var item in completeList2)
            {
                Possession possession = item.Item;
                try
                {
                    possession.LinkOfImageID = item.Api.First().link;
                }
                catch (Exception e)
                {
                    Console.WriteLine("API was not found for Possession: " + possession.Name);
                }                

                list1.Add(possession);
            }

            List = list1;

            APIFetcher.RunAllDownloadsAsync();
        }

        public void LoadPossessionsList()
        {
            //using (var context = new DboPossessionContext())
            //{
            //    var query = context.Possessions.ToList();
            //    var config = new MapperConfiguration(cfg => cfg.CreateMap<DboPossession, Possession>());
            //    var mapper = new Mapper(config);
            //    List = mapper.Map<List<Possession>>(query);

            //    var apiList = context.ApiLinks;
            //    var imageList = context.ImageLinks;

            //    var completeList =
            //    from a in apiList
            //    join l in List
            //    on a.Id equals l.ApiLinkID
            //    select new { Item = l, Link = a.Url, Type = a.Type, Headers = a.Headers };

            //    List<Possession> list1 = new List<Possession>();

            //    foreach (var item in completeList)
            //    {
            //        Possession possession = item.Item;
            //        possession.Type = item.Type;
            //        ApiLink apiLink = new ApiLink
            //        {
            //            Headers = item.Headers,
            //            Url = item.Link,
            //            Type = item.Type
            //        };
            //        APIFetcher.AddDownloadEntity(apiLink, (IApiCallback)item.Item);
            //    }

            //    var completeList2 = List.GroupJoin(imageList, a => a.LinkOfImageID, b => b.id, (item, api) => new
            //    {
            //        Item = item,
            //        Api = api
            //    });

            //    foreach (var item in completeList2)
            //    {
            //        Possession possession = item.Item;
            //        try
            //        {
            //            possession.LinkOfImageID = item.Api.First().link;
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine("API was not found for Possession: " + possession.Name);
            //        }

            //        list1.Add(possession);
            //    }
            //}
        }
    }
}
