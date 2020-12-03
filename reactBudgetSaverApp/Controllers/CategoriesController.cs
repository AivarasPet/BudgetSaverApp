using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetSaverApp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my_new_app.Controllers
{
    [ApiController]
    

    public class Category
    {
        public string Name { get; set; }
    }
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        public List<Category> CategoryConvert (string[] firstArray)
        {
            List<Category> data = new List<Category>();
            for (int i = 0; i < firstArray.Length; i++)
            {
                data.Add(new Category { Name = firstArray[i] });
            }
            return data;
        }

        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return CategoryConvert(_categoryService.GetCategories());
        } 
    }
}
