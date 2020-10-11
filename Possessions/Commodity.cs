using System;

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
