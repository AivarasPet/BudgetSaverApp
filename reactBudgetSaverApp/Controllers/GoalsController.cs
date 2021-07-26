using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Goals;
using BudgetSaverApp.Statistics;
using BudgetSaverApp.UserData;
using Microsoft.AspNetCore.Authorization;
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
        public int Id { get; set; }
    }
    [Authorize]
    public class GoalsController : ControllerBase
    {
        private IGoalsService _goalsService;
        private IUserIDService _UserIDService;
        public GoalsController(IGoalsService goalsService, IUserIDService userIDService)
        {
            _goalsService = goalsService;
            _UserIDService = userIDService;
        }
        public ActionResult<int> GetGoalDaysLeft() => _goalsService.GetGoalDaysLeft();
        public ActionResult<string> MainGoalName() => _goalsService.GetGoalItemName();
        public ActionResult<float> MainGoalPrice() => _goalsService.GetGoalItemPrice();



        public ActionResult<List<DboGoal>> GoalValues()
        {
            List<DboGoal> goals = _goalsService.GetUserGoals(_UserIDService.GetUserID());
            return goals;
        }

        public ActionResult<float> UserData()
        {
            //DataRow userDataRow = _goalsService.GetUserData(1);
            //float currentSavings = float.Parse(userDataRow["CurrentSavings"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
            //return currentSavings;
            return 1000;
        }

        [HttpPost]
        public ActionResult<Goal> PostAddGoal([FromBody] InputGoal values)
        {
            try
            {
                _goalsService.AddNewGoal(values.inputName, values.inputAmount, values.inputDescription, _UserIDService.GetUserID());

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
                _goalsService.UpdateGoal(values.inputName, values.inputAmount, values.inputDescription, values.Id , _UserIDService.GetUserID());

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
                _goalsService.DeleteGoal(id, _UserIDService.GetUserID());
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
