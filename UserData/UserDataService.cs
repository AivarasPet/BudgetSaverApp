using BudgetSaverApp.Goals;
using BudgetSaverApp.Other;
using BudgetSaverApp.Portfolio;
using BudgetSaverApp.UserData;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace BudgetSaverApp
{
    public class UserDataService : IUserDataService
    {

        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserDataService(IHttpContextAccessor httpContextAccessor) //, IHttpContextAccessor httpContextAccessor
        {
            _httpContextAccessor = httpContextAccessor;
            //ReadFromFile();
        }


        public int GetUserID()
        {
            return int.Parse(_httpContextAccessor.HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
        }
    }
}

