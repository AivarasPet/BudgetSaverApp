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

    public class PossessionController : Controller
    {
        private IPossessionsService _possessionsService;
        public PossessionController(IPossessionsService possessionsService)
        {
            _possessionsService = possessionsService;
        }
        public IEnumerable<Possession> Index()
        {
            return _possessionsService.GetPossessionsList().ToArray();
        }

        public ActionResult<float> TotalPossessionValue()
        {
            return _possessionsService.TotalPossessionValue();
        }

        public ActionResult<float> PossessionInflationValue()
        {
            return _possessionsService.TotalPossessionInflation();
        }
    }
}
