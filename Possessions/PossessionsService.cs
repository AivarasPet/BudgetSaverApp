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

        public float TotalPossessionValue()
        {
            return List.Aggregate(new float(), (sum, next) => sum + next.ValueInDollarsWhenBought);
        }

        public float TotalPossessionInflation()
        {
            float value = TotalPossessionValue();
            float percentage = PublicValues.InflationInARecentYear();
            float price = value * percentage;
            return price;
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
