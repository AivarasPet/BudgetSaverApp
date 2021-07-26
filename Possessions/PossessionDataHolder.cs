using AutoMapper;
using BudgetSaverApp.Other;
using BudgetSaverApp.Possessions.Links;
using BudgetSaverApp.Pricing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{
    public class PossessionDataHolder
    {
        public List<PossessionBackup> PossessionBackups { get; set; }
        Mapper mapperBackup = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DboPossessionData, PossessionBackup>()));
        private readonly IServiceScopeFactory scopeFactory;

        public PossessionDataHolder(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
            LoadPossessionsBackupList();
        }

        public void Activate() { }

        public void LoadPossessionsBackupList()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DboContext>();
                PossessionBackups = mapperBackup.Map<List<PossessionBackup>>(db.PossessionsData);
                APIFetcher apiFetcher = new APIFetcher();
                List<DboPossessionData> List = db.PossessionsData.ToList();

                for (var x = 0; x < PossessionBackups.Count; x++)
                {
                    ApiLink apiLink = new ApiLink
                    {
                        Headers = List.ElementAt(x).Headers,
                        Url = List.ElementAt(x).UrlAPI,
                        Type = List.ElementAt(x).Type
                    };

                    apiFetcher.AddDownloadEntity(apiLink, (IApiCallback)PossessionBackups.ElementAt(x));
                }

                apiFetcher.RunAllDownloadsAsync();
            }
        }

    }
}
