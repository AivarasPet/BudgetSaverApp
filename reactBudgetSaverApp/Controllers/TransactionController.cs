using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_new_app.Controllers
{
    [Route("[controller]")]
    public class TransactionController: ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public TransactionController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            var rng = new Random();
            ITransactionService transactionService = Session.serviceManager.transactionService;
            return transactionService.GetTransactionsList().ToArray();
            
        }
    }
}
