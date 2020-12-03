using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.Statistics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_new_app.ModelsToBeFetched;

namespace my_new_app.Controllers
{

    public class StatisticController : Controller
    {
        private IStatisticsService _statisticsService;
        public StatisticController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        public IActionResult Index()
        {
            return Content("Hello");
        }

        public ActionResult<Stats> ThisWeek() => _statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now);

        public ActionResult<Stats> LastWeek() => _statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek - 6), DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + 1));

        public ActionResult<Stats> ThisMonth() => _statisticsService.GetStatistic(DateTime.Today.Date.AddDays(1 - DateTime.Today.Day), DateTime.Now);

        public ActionResult<Stats> LastMonth()
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            return _statisticsService.GetStatistic(first, last);
        }

        public ActionResult<Stats> Advanced(DateTime startDate,DateTime endDate)
        {
            
            return statisticsService.GetStatistic(startDate, endDate);
        }


        public ActionResult<IEnumerable<FinancialFeedbackByCategory>> GetPreviousMonthFeedback()
        {
            return statisticsService.GetFinancialFeedackByCategoryPreviousMonth();
        }

    }
}
