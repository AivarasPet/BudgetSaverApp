using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Transactions;
using BudgetSaverApp.Statistics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace my_new_app.Controllers
{

    public class StatisticController : Controller
    {
        readonly IStatisticsService statisticsService = Session.serviceManager.statisticsService;


        public IActionResult Index()
        {
            return Content("Hello");
        }

        public ActionResult<Stats> ThisWeek() => statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now);

        public ActionResult<Stats> LastWeek() => statisticsService.GetStatistic(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek - 6), DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + 1));

        public ActionResult<Stats> ThisMonth() => statisticsService.GetStatistic(DateTime.Today.Date.AddDays(1 - DateTime.Today.Day), DateTime.Now);

        public ActionResult<Stats> LastMonth()
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            return statisticsService.GetStatistic(first, last);
        }
        public ActionResult<Stats> CustomDate() => statisticsService.GetStatistic(DateTime.Today.Date.AddDays(1 - DateTime.Today.Day), DateTime.Now);

    }
}
