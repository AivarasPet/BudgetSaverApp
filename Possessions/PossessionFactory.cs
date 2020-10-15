using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Possessions
{
    public class PossessionFactory
    {
        public static IPosessionsService GetPossessionsService()
        {
            return new PossessionsService();
        }

            
    }
}
