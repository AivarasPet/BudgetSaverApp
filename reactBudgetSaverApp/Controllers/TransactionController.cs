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

namespace my_new_app.Controllers
{
    public class TransactionController : ControllerBase
    {

        public ActionResult<IEnumerable<Transaction>> Index()
        {
            ITransactionService transactionService = Session.serviceManager.transactionService;
            return transactionService.GetTransactionsList().ToArray();

        }

        public ActionResult Test()
        {
            
            return Ok();
        }
        
        [HttpPost]
        public ActionResult<Transaction> PostAddTransaction([FromBody] Transaction values)
        {
            ITransactionService transactionService = Session.serviceManager.transactionService;
            try
            {
                transactionService.AddNewTransaction(values.TransactType, values.Title, values.Amount.ToString(), values.Category);
                
            }catch (BadCategoryException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }catch (ArgumentException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
            return values;
        }        
    }
}
