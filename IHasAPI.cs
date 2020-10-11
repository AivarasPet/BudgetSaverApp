using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    public interface IHasAPI
    {
        void OnAPIDownload(string APIData);
    }
}
