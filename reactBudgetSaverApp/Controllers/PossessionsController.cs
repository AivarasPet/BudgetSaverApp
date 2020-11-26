using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Possessions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_new_app.Controllers
{
    public class PossessionsController : ControllerBase
    {
        public ActionResult<IEnumerable<Possession>> Index()
        {
            IPosessionsService possessionService = Session.serviceManager.posessionsService;
            return possessionService.GetPossessionsList().ToArray();
        }

    }
}
