using BudgetSaverApp.UserData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Controllers
{


    public class UserLoginData
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class UserController : ControllerBase
    {
        private IJwtAuthenticationManager JwtAuthenticationManager;
        public UserController(IJwtAuthenticationManager JwtAuthenticationManager)
        {
            this.JwtAuthenticationManager = JwtAuthenticationManager;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult LoginAttempt([FromBody] UserLoginData values)
        {
            var token = JwtAuthenticationManager.AuthenticateUser(values.email, values.password);
            if (token == null) 
                return Unauthorized();
            return Ok(token);
        }
    }
}
