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
        private ITransactionService _transactionService;
        public StatisticController(IStatisticsService statisticsService, ITransactionService transactionService)
        {
            _statisticsService = statisticsService;
            _transactionService = transactionService;
        }

        public IActionResult Index()
        {
            return Content("Hello");
        }

        public ActionResult<Stats> ThisWeek() => new Stats(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now, _transactionService);

        public ActionResult<Stats> LastWeek() => new Stats(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek - 6), DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + 1), _transactionService);

        public ActionResult<Stats> ThisMonth() => new Stats(DateTime.Today.Date.AddDays(1 - DateTime.Today.Day), DateTime.Now, _transactionService);

        public ActionResult<Stats> LastMonth()
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            return new Stats(first, last, _transactionService);
        }

        public ActionResult<Stats> Advanced(DateTime startDate,DateTime endDate)
        {

            return new Stats(startDate, endDate, _transactionService);

        }


        public ActionResult<string> GetTopEarnings()
        {
            string sss = _statisticsService.getTopEarnings();
            return sss;
        }


        public ActionResult<IEnumerable<FinancialFeedbackByCategory>> GetPreviousMonthFeedback()
        {

             List<FinancialFeedbackByCategory> sss  = _statisticsService.GetFinancialFeedackByCategoryPreviousMonth();
            return sss;
        }

    }
}
