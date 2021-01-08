using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Other;
using BudgetSaverApp.Possessions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_new_app.Controllers
{


    public class PossessionInfo
    {
        public string PossessionName { get; set; }
        public float Amount { get; set; }
    }

    public class PossessionController : ControllerBase
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

        public IEnumerable<string> Names()
        {
            return _possessionsService.GetAllPossessionNames();
        }

        public IEnumerable<string> OwnedPossessionNames()
        {
            return _possessionsService.GetOwnedPossessionNames();
        }


        [HttpPost]
        public ActionResult<IEnumerable<Possession>> PostAddPossession([FromBody] PossessionInfo possession)
        {
            _possessionsService.InsertPossession(possession.PossessionName, possession.Amount, 1);
            return _possessionsService.GetPossessionsList().ToArray();
        }

        [HttpPost]
        public ActionResult<IEnumerable<Possession>> PostUpdatePossession([FromBody] PossessionInfo possession)
        {
            _possessionsService.UpdatePossession(possession.PossessionName, possession.Amount, 1);
            return _possessionsService.GetPossessionsList().ToArray();
        }
        public ActionResult<IEnumerable<Possession>> DeletePossession(string possessionName)
        {
            try
            {
                _possessionsService.DeletePossession(possessionName, 1);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
            return _possessionsService.GetPossessionsList().ToArray();
        }

    }
}
