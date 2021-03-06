﻿using Newtonsoft.Json;
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
        List<Possession> List = new List<Possession>();
        private DboContext _DboPossessionContext;
        private string connectionString;

        public PossessionsService(DboContext dboContext) //, ConnectionStringHelper connectionStringHelper
        {
            connectionString = "Server =.\\SQLEXPRESS; Database = BudgetSaverDatabase; Trusted_Connection = True;";// connectionStringHelper.ConnectionString;
            _DboPossessionContext = dboContext;
            LoadPossessionsList();
        }

        public void DeletePossession(string possessionName, int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Possessions WHERE UserId = @userId AND ApiLinkID = (SELECT ID FROM dbo.PossessionsApiLinks WHERE name = @possessionName)", con);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                cmd.Parameters.Add(new SqlParameter("@possessionName", possessionName));

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                con.Close();
            }
        }

        public void UpdatePossession(string possessionName, float amount, int userId)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE dbo.Possessions SET Amount = @amount FROM dbo.Possessions WHERE UserId = @userId AND ApiLinkID = (SELECT ID FROM dbo.PossessionsApiLinks WHERE name = @possessionName)", con);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                cmd.Parameters.Add(new SqlParameter("@possessionName", possessionName));
                cmd.Parameters.Add(new SqlParameter("@amount", amount));

                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                con.Close();
            }
            
        }

        public List<string> GetAllPossessionNames()
        {
            var arr = _DboPossessionContext.PossessionsApiLinks.Select(x => x.ID).Except(_DboPossessionContext.Possessions.Select(y => y.ApiLinkID)).ToList();
            return _DboPossessionContext.PossessionsApiLinks.Where(x => arr.Contains(x.ID)).Select(x => x.Name).ToList();
        }
        public List<string> GetOwnedPossessionNames()
        {
            var arr = from L in _DboPossessionContext.PossessionsApiLinks
                      join P in _DboPossessionContext.Possessions
                      on L.ID equals P.ApiLinkID
                      select L.Name;
            return arr.ToList();
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
            List = new List<Possession>();
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

        public void InsertPossession(float amount, int possessionLinkID, int imageLinkID, float valueInDollarsWhenBought, int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Possessions([Amount],[ApiLinkID],[LinkOfImageID],[ValueInDollarsWhenBought],[UserID]) VALUES (@amount, @apiLinkID@, linkOfImageID, @valueInDollarsWhenBought, @userId)", con);
                cmd.Parameters.Add(new SqlParameter("@amount", amount));
                cmd.Parameters.Add(new SqlParameter("@apiLinkID", possessionLinkID));
                cmd.Parameters.Add(new SqlParameter("@linkOfImageID", imageLinkID));
                cmd.Parameters.Add(new SqlParameter("@valueInDollarsWhenBought", valueInDollarsWhenBought));
                cmd.Parameters.Add(new SqlParameter("@userId", userId)); 

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                con.Close();
            }
        }

        public void InsertPossession(string name, float amount, int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("  INSERT INTO dbo.Possessions([Amount],[ApiLinkID],[LinkOfImageID],[ValueInDollarsWhenBought], [LastEdited],[UserID]) VALUES (@amount, (SELECT MAX(ID) FROM dbo.PossessionsAPILinks WHERE NAME = @name), 2, 0,'10-10-2013', @userId)", con);
                cmd.Parameters.Add(new SqlParameter("@amount", amount));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@userId", userId));

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                con.Close();
            }
        }
    }
}
