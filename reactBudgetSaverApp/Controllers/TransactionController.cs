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
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string country { get; set; }
        public Student()
        {

        }
    }
    public class TransactionController : ControllerBase
    {

        public ActionResult<IEnumerable<Transaction>> Index()
        {
            ITransactionService transactionService = Session.serviceManager.transactionService;
            return transactionService.GetTransactionsList().ToArray();

        }

        public ActionResult Test()
        {
            System.Diagnostics.Debug.WriteLine("sup");
            return Ok();
        }
        
        [HttpPost]
        public ActionResult<Transaction> PostAddTransaction([FromBody] Transaction values)
        {
            ITransactionService transactionService = Session.serviceManager.transactionService;
            transactionService.AddNewTransaction(values.TransactType, values.Title, values.Amount.ToString(), values.Category);
            return values;
        }        
    }
}
