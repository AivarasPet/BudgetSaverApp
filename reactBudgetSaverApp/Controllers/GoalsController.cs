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

    public class GoalsController : Controller
    {
        readonly IGoalsService goalsService = Session.serviceManager.goalsService;

        public float ThisWeek() => goalsService.GetGoalDaysLeft();

    }
}
