using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetSaverApp;
using BudgetSaverApp.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static BudgetSaverApp.CategoryService;

namespace my_new_app.Controllers
{

    
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        

        public ActionResult<TransactionCategoriesMeshed> GetTransactionCategories()
        {
            var x = _categoryService.GetTransactionCategories();
            return x;
        } 
    }
}
