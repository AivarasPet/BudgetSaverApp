using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Goals;
using BudgetSaverApp.Statistics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace my_new_app.Controllers
{
    class floatObject
    {
        public float profit { get; set; }
    }
    public class GoalsController : Controller
    {
        private IGoalsService _goalsService;
        private IPossessionsService _possessionsService;
        public GoalsController(IGoalsService goalsService, IPossessionsService possessionsService)
        {
            _goalsService = goalsService;
            _possessionsService = possessionsService;
        }
        public ActionResult<int> GetGoalDaysLeft() => _goalsService.GetGoalDaysLeft();

        public ActionResult<Tuple<string, float, float, float, float>> GoalValues()
        {
           return _goalsService.GetGoals();
        }

    }
}
