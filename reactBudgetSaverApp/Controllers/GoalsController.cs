using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        public GoalsController(IGoalsService goalsService)
        {
            _goalsService = goalsService;
        }
        public ActionResult<int> GetGoalDaysLeft() => _goalsService.GetGoalDaysLeft();
        public ActionResult<string> MainGoalName() => _goalsService.GetGoalItemName();
        public ActionResult<float> MainGoalPrice() => _goalsService.GetGoalItemPrice();

        public IEnumerable<Goal> GoalValues()
        {
            List<Goal> goals = new List<Goal>();
            DataTable goalTable = _goalsService.GetGoalTable(1);
            foreach (DataRow goal in goalTable.Rows)
            {
                goals.Add(new Goal()
                {
                    GoalItemName = goal["GoalItemName"].ToString(),
                    GoalItemPrice = float.Parse(goal["GoalItemPrice"].ToString(), CultureInfo.InvariantCulture.NumberFormat),
                    GoalDescription = goal["GoalDescription"].ToString()
                });

            }


            return goals.ToArray();
        }
    }
}
