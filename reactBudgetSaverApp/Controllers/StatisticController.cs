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
using Microsoft.AspNetCore.Authorization;
using BudgetSaverApp.UserData;

namespace my_new_app.Controllers
{
    [Authorize]
    public class StatisticController : Controller
    {
        private IStatisticsService _statisticsService;
        private ITransactionService _transactionService;
        private IUserIDService _UserIDService;
        public StatisticController(IStatisticsService statisticsService, ITransactionService transactionService, IUserIDService userIDService)
        {
            _statisticsService = statisticsService;
            _transactionService = transactionService;
            _UserIDService = userIDService;
        }

        public IActionResult Index()
        {
            return Content("Hello");
        }

        public ActionResult<Stats> ThisWeek() 
           {
            Stats stat = new Stats(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday), DateTime.Now, _transactionService, _UserIDService.GetUserID()); 
            return stat;
           }

        public ActionResult<Stats> LastWeek() => new Stats(DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek - 6), DateTime.Today.Date.AddDays(-(int)DateTime.Today.DayOfWeek + 1), _transactionService, _UserIDService.GetUserID());

        public ActionResult<Stats> ThisMonth() => new Stats(DateTime.Today.Date.AddDays(1 - DateTime.Today.Day), DateTime.Now, _transactionService, _UserIDService.GetUserID());

        public ActionResult<Stats> LastMonth()
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            return new Stats(first, last, _transactionService, _UserIDService.GetUserID());
        }

        public ActionResult<Stats> Advanced(DateTime startDate,DateTime endDate)
        {

            return new Stats(startDate, endDate, _transactionService, _UserIDService.GetUserID());

        }

        public ActionResult<float> GetProfit()
        {
            return _statisticsService.DailyProfit(_UserIDService.GetUserID());
        }

        public ActionResult<string> GetTopEarnings()
        {
            string sss = _statisticsService.GetTopEarnings(_UserIDService.GetUserID());
            return sss;
        }


        public ActionResult<IEnumerable<FinancialFeedbackByCategory>> GetPreviousMonthFeedback()
        {

             List<FinancialFeedbackByCategory> sss  = _statisticsService.GetFinancialFeedackByCategoryPreviousMonth(_UserIDService.GetUserID());
            return sss;
        }

    }
}
