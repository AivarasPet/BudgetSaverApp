using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions.Links
{
    public class DboPossessionData
        
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string UrlAPI { get; set; }
        public string UrlImage { get; set; }
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();
    }
}
