using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using BudgetSaverApp.Pricing;
using System.IO;
using BudgetSaverApp.Possessions.Links;
using System.Linq;
using AutoMapper;
using BudgetSaverApp.Other;

namespace BudgetSaverApp.Possessions
{
    
    public class PossessionsService : IPossessionsService
    {
        List<Possession> List = new List<Possession>();
        private DboContext _DboPossessionContext;

        public PossessionsService(DboContext dboContext)
        {
            _DboPossessionContext = dboContext;
            LoadPossessionsList();
        }

        public List<Possession> GetPossessionsList()
        {
            return List ?? null;
        }

     
        public void LoadPossessionsListFile() {
            //List.Clear();
            //string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\Possessions.json");
            
            //if (json == null) return;

            //List = JsonConvert.DeserializeObject<List<Possession>>(json);
            
            //string apiJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\APILinks.json");
            //string imageJson = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data\ImageLinks.json");

            //List<ApiLink> apiList = JsonConvert.DeserializeObject<List<ApiLink>>(apiJson);
            //List<ImageLink> imageList = JsonConvert.DeserializeObject<List<ImageLink>>(imageJson);

            //var completeList =
            //    from a in apiList
            //    join l in List
            //    on a.ID equals l.ApiLinkID
            //    select new {Item = l, Link = a.Url, Type = a.Type, Headers = a.Headers};

            //List<Possession> list1 = new List<Possession>();

            //foreach(var item in completeList)
            //{              
            //    Possession possession = item.Item;
            //    possession.Type = item.Type;
            //    ApiLink apiLink = new ApiLink
            //    {
            //        Headers = item.Headers,
            //        Url = item.Link,
            //        Type = item.Type
            //    };                
            //    APIFetcher.AddDownloadEntity(apiLink, (IApiCallback) item.Item);
            //}

            //var completeList2 = List.GroupJoin(imageList, a => a.ApiLinkID, b => b.ID, (item, api) => new
            //{
            //    Item = item,
            //    Api = api
            //});

            //foreach (var item in completeList2)
            //{
            //    Possession possession = item.Item;
            //    try
            //    {
            //        possession.ImageUrl = item.Api.First().link;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("API was not found for Possession: " + possession.Name);
            //    }                

            //    list1.Add(possession);
            //}

            //List = list1;

            //APIFetcher.RunAllDownloadsAsync();
        }
        //naudot viena context, 
        //Atskirt headers nuo ApiLink
        //ToList() Uzkrauna ramus, too many sql queries
        public void LoadPossessionsList()
        {
            APIFetcher apiFetcher = new APIFetcher();

            var completeList =
            from a in _DboPossessionContext.PossessionsApiLinks
            join p in _DboPossessionContext.Possessions
            on a.ID equals p.ApiLinkID
            join i in _DboPossessionContext.ImageLinks
            on p.LinkOfImageID equals i.ID
            select new { dboPossession = p, apiLink = a, imageUrl = i.link };

            List<Possession> list1 = new List<Possession>();

            foreach (var item in completeList)
            {
                Possession possession = (item.apiLink.Type) switch
                {
                    "Crypto"    => new Crypto(),
                    "Stock"     => new Stock(),
                    "Commodity" => new Commodity(),
                    _           => throw new NotImplementedException(),
                };

                possession.Name = item.apiLink.Name;
                possession.ImageUrl = item.imageUrl;
                possession.LastEdited = item.dboPossession.LastEdited;
                possession.Amount = item.dboPossession.Amount;
                possession.Type = item.apiLink.Type;
                possession.ValueInDollarsWhenBought = item.dboPossession.ValueInDollarsWhenBought;

                ApiLink apiLink = new ApiLink
                {
                    Headers = item.apiLink.Headers,
                    Url = item.apiLink.Url,
                    Type = item.apiLink.Type
                };

                apiFetcher.AddDownloadEntity(apiLink, (IApiCallback)possession);
                List.Add(possession);
            }

            apiFetcher.RunAllDownloadsAsync();
        }
    }
}
