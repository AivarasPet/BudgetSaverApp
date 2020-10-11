using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{
    class Commodity : Possession, IHasAPI
    {
        public void OnAPIDownload(string APIData)
        {
            throw new NotImplementedException();
        }
    }
}
