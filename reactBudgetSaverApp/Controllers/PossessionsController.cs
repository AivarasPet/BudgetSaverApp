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
        private IPossessionsService _possessionsService;
        public  PossessionsController(IPossessionsService possessionsService)
        {
            _possessionsService = possessionsService;
        }
        public ActionResult<IEnumerable<Possession>> Index()
        {
            return _possessionsService.GetPossessionsList().ToArray();
        }      
    }
}
