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

    public class InputGoal
    {
        public string inputName { get; set; }
        public float inputAmount { get; set; }
        public string inputDescription { get; set; }
    }

    public class UpdateGoal : InputGoal
    {
        public int goalId { get; set; }
    }
    public class GoalsController : ControllerBase
    {
        private IGoalsService _goalsService;
        public GoalsController(IGoalsService goalsService)
        {
            _goalsService = goalsService;
        }
        public ActionResult<int> GetGoalDaysLeft() => _goalsService.GetGoalDaysLeft();
        public ActionResult<string> MainGoalName() => _goalsService.GetGoalItemName();
        public ActionResult<float> MainGoalPrice() => _goalsService.GetGoalItemPrice();



        public ActionResult<IEnumerable<Goal>> GoalValues()
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

        public ActionResult<float> UserData()
        {
            DataRow userDataRow = _goalsService.GetUserData(1);
            float currentSavings = float.Parse(userDataRow["CurrentSavings"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
            return currentSavings;
        }

        [HttpPost]
        public ActionResult<Goal> PostAddGoal([FromBody] InputGoal values)
        {
            try
            {
                _goalsService.AddNewGoal(values.inputName, values.inputAmount, values.inputDescription, 1);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
            return new Goal() { GoalItemName = values.inputName, GoalItemPrice = values.inputAmount, GoalDescription = values.inputDescription};
        }

        [HttpPost]
        public ActionResult<UpdateGoal> PostUpdateGoal([FromBody] UpdateGoal values)
        {
            try
            {
                _goalsService.UpdateGoal(values.inputName, values.inputAmount, values.inputDescription, values.goalId ,1);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
            return values;
        }

        public ActionResult DeleteGoal(int id)
        {

            try
            {
                _goalsService.DeleteGoal(id, 1);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
