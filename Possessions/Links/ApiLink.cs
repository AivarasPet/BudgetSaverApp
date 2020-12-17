using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions.Links
{
    public class ApiLink
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public Dictionary<string, string> Headers { get; set; }
    }
}
