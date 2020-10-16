using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.Statistics
{
    public interface IStatisticsService
    {
        public Stats GetStatistic(DateTime startDate, DateTime endDate);
    
    }
}
