using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{
    public interface IPossessionDataHolder
    {
        public List<PossessionBackup> PossessionBackups { get; set; }
    }
}
