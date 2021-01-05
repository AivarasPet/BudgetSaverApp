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

        public ActionResult<Tuple<string, float, float, float, int>> GoalValues()
        {
            List<Goal> goals = new List<Goal>();
            List<string> hehe = new List<string>();
            DataTable goalTable = _goalsService.GetGoalTable(1);
            foreach (DataRow goal in goalTable.Rows)
            {
                goals.Add(new Goal()
                {
                    GoalItemName = goal["Name"].ToString(),
                    GoalItemPrice = float.Parse(goal["Price"].ToString(), CultureInfo.InvariantCulture.NumberFormat),
                    GoalDescription = goal["Description"].ToString()
                });

            }


            return _goalsService.GetGoals();
        }
    }
}
