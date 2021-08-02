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
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace BudgetSaverApp.Possessions
{
    

    public class PossessionsService : IPossessionsService
    {
        //List<PossessionBackup> Backups = new List<PossessionBackup>();
        private DboContext _DboContext;
        PossessionDataHolder _PossessionDataHolder;

        public PossessionsService(DboContext dboContext, PossessionDataHolder possessionDataHolder) 
        {
            _DboContext = dboContext;
            _PossessionDataHolder = possessionDataHolder;
            //LoadPossessionsBackupList();
        }




        public void DeletePossession(string possessionName, int userId)
        {
            int possessionId = _DboContext.PossessionsData.First(u => u.Name == possessionName).ID;
            var toDelete = _DboContext.Possessions.Where(x => x.UserID == userId && x.PossessionDataID == possessionId).FirstOrDefault();
            _DboContext.Remove(toDelete);
            _DboContext.SaveChanges();
        }

        public void UpdatePossession(string possessionName, float amount, int userId)
        {
            int possessionId = _DboContext.PossessionsData.First(u => u.Name == possessionName).ID;
            var toUpdate = _DboContext.Possessions.Where(x => x.UserID == userId && x.PossessionDataID == possessionId).FirstOrDefault();
            toUpdate.Amount = amount;
            _DboContext.SaveChanges();
        }

        public List<string> GetAllPossessionNames(int userId)
        {
            var arr = _DboContext.PossessionsData.Select(x => x.ID).Except(_DboContext.Possessions.Select(y => y.PossessionDataID)).ToList();
            return _DboContext.PossessionsData.Where(x => arr.Contains(x.ID)).Select(x => x.Name).ToList();
        }
        public List<string> GetOwnedPossessionNames(int userId)
        {
            var arr = (from B in _PossessionDataHolder.PossessionBackups
                      join P in _DboContext.Possessions
                      on B.ID equals P.PossessionDataID
                      where P.UserID == userId
                      select B.Name).ToList();
            return arr;
        }

        public List<Possession> GetPossessionsList(int userID)
        {
            var filtered = _DboContext.Possessions.Where(x => x.UserID == userID).ToList();
            var arr = (from P in filtered
                      join B in _PossessionDataHolder.PossessionBackups
                      on P.PossessionDataID equals B.ID
                      select new Possession
                      {
                          Type = B.Type
                      ,
                          Amount = P.Amount
                      ,
                          Name = B.Name
                      ,
                          UrlImage = B.UrlImage
                      ,
                          LastEdited = P.LastEdited
                      ,
                          ValueInDollars = B.Price
                      ,
                          ValueInDollarsWhenBought = P.ValueInDollarsWhenBought
                      ,
                          PercentageChangeInValue = (P.ValueInDollarsWhenBought != 0) ? (B.Price / P.ValueInDollarsWhenBought-1) * 100 : 0
                      }).ToList();
            return arr;
        }

        public FloatObj TotalPossessionValue(int userID)
        {
            return new FloatObj { Float = GetPossessionsList(userID).Aggregate(new float(), (sum, next) => sum + next.ValueInDollarsWhenBought) };
        }

        public float TotalPossessionInflation(int userID)
        {
            FloatObj value = TotalPossessionValue(userID);
            float percentage = PublicValues.InflationInARecentYear();
            float price = value.Float * percentage;
            return price;
        }


        public void InsertPossession(string possessionName, float amount, int userId)
        {
            int possessionId = _DboContext.PossessionsData.First(u => u.Name == possessionName).ID;
            var y = _PossessionDataHolder.PossessionBackups.Find(x => x.ID == possessionId).Price;
            var x = new DboPossession
            {
                Amount = amount,
                LastEdited = DateTime.Now,
                PossessionDataID = possessionId,
                UserID = userId,
                ValueInDollarsWhenBought = y
            };
            _DboContext.Possessions.Add(x);
            _DboContext.SaveChanges();
        }
    }
}
