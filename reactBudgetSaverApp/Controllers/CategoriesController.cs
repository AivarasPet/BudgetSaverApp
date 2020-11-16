using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_new_app.Controllers
{
    [ApiController]
    

    public class category
    {
        public string name { get; set; }
    }
    public class CategoriesController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public CategoriesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        
        public List<category> categoryConvert (string[] firstArray)
        {
            List<category> data = new List<category>();
            for (int i = 0; i < firstArray.Length; i++)
            {
                data.Add(new category { name = firstArray[i] });
            }
            return data;
        }

        public ActionResult<IEnumerable<category>> getCategories()
        {
            return categoryConvert(Session.serviceManager.categoryService.GetCategories());
        } 
    }
}
