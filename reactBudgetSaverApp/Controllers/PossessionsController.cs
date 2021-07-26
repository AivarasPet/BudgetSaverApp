using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Other;
using BudgetSaverApp.Possessions;
using BudgetSaverApp.UserData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_new_app.Controllers
{


    public class PossessionInfo
    {
        public int PossessionId { get; set; }
        public float Amount { get; set; }
    }
    [Authorize]
    public class PossessionController : ControllerBase
    {
        private IPossessionsService _possessionsService;
        private IUserIDService _UserIDService;
        public PossessionController(IPossessionsService possessionsService, IUserIDService userIDService)
        {
            _possessionsService = possessionsService;
            _UserIDService = userIDService;
        }
        public IEnumerable<Possession> Index()
        {
            return _possessionsService.GetPossessionsList(_UserIDService.GetUserID()).ToArray();
        }



        public ActionResult<float> TotalPossessionValue()
        {
            return _possessionsService.TotalPossessionValue(_UserIDService.GetUserID()).Float;
        }

        public ActionResult<float> PossessionInflationValue()
        {
            return _possessionsService.TotalPossessionInflation(_UserIDService.GetUserID());
        }

        public IEnumerable<string> Names()
        {
            return _possessionsService.GetAllPossessionNames(_UserIDService.GetUserID());
        }

        public IEnumerable<string> OwnedPossessionNames()
        {
            return _possessionsService.GetOwnedPossessionNames(_UserIDService.GetUserID());
        }


        [HttpPost]
        public ActionResult<IEnumerable<Possession>> PostAddPossession([FromBody] PossessionInfo possession)
        {
            _possessionsService.InsertPossession(possession.PossessionId, possession.Amount, _UserIDService.GetUserID());
            return _possessionsService.GetPossessionsList(_UserIDService.GetUserID()).ToArray();
        }

        [HttpPost]
        public ActionResult<IEnumerable<Possession>> PostUpdatePossession([FromBody] PossessionInfo possession)
        {
            return null;
            _possessionsService.UpdatePossession(possession.PossessionId, possession.Amount, _UserIDService.GetUserID());
            return _possessionsService.GetPossessionsList(_UserIDService.GetUserID()).ToArray();
        }
        public ActionResult<IEnumerable<Possession>> DeletePossession(int possessionId)
        {
            try
            {
                _possessionsService.DeletePossession(possessionId, _UserIDService.GetUserID());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
            //return _possessionsService.GetPossessionsList().ToArray();
            return null;
        }

    }
}
