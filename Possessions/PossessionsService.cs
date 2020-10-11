using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace BudgetSaverApp.Possessions
{
    public class PossessionsService
    {
        List<Possession> list = new List<Possession>();

        public PossessionsService()
        {
            InitList();
            foreach (Possession p in list) { Console.WriteLine(p); }
        }



        private void InitList() {
            list.Clear();
            ListItemTransactions[] listItems = new ListItemTransactions[20];
            TextFileReader reader = new TextFileReader();
            string[] data = reader.FetchStringArrayByLocation(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\Data\Possessions.txt");
            if (data == null) return;

            for (int x = 0; x < data.Length; x++)
            {
                if (data[x] == "") continue;
                Console.WriteLine("write " + data[x]);

                int posOfSepperator = data[x].IndexOf(':');
                string possessionType = data[x].Substring(0, posOfSepperator);
                string jsonObjStr = data[x].Substring(posOfSepperator + 1, data[x].Length - possessionType.Length - 2);
                
                JObject o = JObject.Parse(jsonObjStr);

                Possession possession = possessionType switch
                {
                    "Crypto" => new Crypto(),
                    "Commodity" => new Commodity(),
                    "Stock" => new Stock(),
                    _ => null
                };


                if (possession != null)
                {
                    JsonConvert.PopulateObject(jsonObjStr, possession);
                    Console.WriteLine(possession.name);
                    list.Add(possession);
                }
                else
                {
                    Console.WriteLine("NONONONONO");
                }
            }
            Console.WriteLine("count: " + list.Count);
                foreach(Possession i in list) { Console.Write(i.name + "amount : " + i.amount+ " XDDD "); }
        }


    }
}
