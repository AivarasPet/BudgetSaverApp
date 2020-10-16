using System;

namespace BudgetSaverApp.Possessions
{
    class Commodity : Possession, IApiCallback
    {
        public void OnAPIDownload(string APIData)
        {
            throw new NotImplementedException();
        }
    }
}
