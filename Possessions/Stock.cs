using System;

namespace BudgetSaverApp.Possessions
{
    class Stock : Possession, IHasAPI
    {

        public void OnAPIDownload(string APIData)
        {
            throw new NotImplementedException();
        }
    }
}
