using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Configuration;
using Microsoft.AspNetCore.Authorization;
using BudgetSaverApp.UserData;

namespace my_new_app.Controllers
{
    [Authorize]
    public class TransactionController : ControllerBase
    {
        ITransactionService _transactionService;
        IUserDataService _userDataService;
        
        public TransactionController(ITransactionService transactionService, IUserDataService userDataService)
        {
            _transactionService = transactionService;
            _userDataService = userDataService;
            //_httpContextAccessor = httpContextAccessor;
            //_userDataService = this._userDataService;
        }


        public ActionResult<IEnumerable<Transaction>> Index()
        { 
            return _transactionService.GetTransactionsList(_userDataService.GetUserID()).ToArray();
        }

        public ActionResult Test()
        {
            
            return Ok();
        }
        
        [HttpPost]
        public ActionResult<Transaction> PostAddTransaction([FromBody] Transaction values)
        {
            try
            {
                _transactionService.AddNewTransaction(values.TransactType, values.Title, values.Amount.ToString(), _userDataService.GetUserID(), values.Category);
                
            }catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
            return values;
        }

        public ActionResult<IEnumerable<Tuple<Transaction,int>>> PostPopularTransactions()
        {
            return _transactionService.GetPopularTransactionTuples(_userDataService.GetUserID()).ToArray();
        }

        [HttpPost]
        public ActionResult<string> PostCheckPopularTransaction([FromBody] string value)
        {
            ITransactionService transactionService = _transactionService;
            //transactionService.CheckPopularTransaction(value);
            //ConfigurationManager.AppSettings["PopularTransaction"];
            //ConfigurationManager
            return value;
        }
    }
}
