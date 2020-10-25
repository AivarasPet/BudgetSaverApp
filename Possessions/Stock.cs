using System;

namespace BudgetSaverApp.Possessions
{
    class Stock : Possession, IApiCallback
    {
        public void OnAPIDownload(string APIData)
        {
            throw new NotImplementedException();
        }
    }
}
