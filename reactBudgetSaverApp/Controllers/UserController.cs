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
        private IUserManager _UserManager;
        public UserController(IUserManager userManager)
        {
            _UserManager = userManager;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult LoginAttempt([FromBody] UserLoginData values)
        {
            var token = _UserManager.AuthenticateUser(values.email, values.password);
            if (token == null) 
                return Unauthorized();
            return Ok(token);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult RegisterAttempt([FromBody] UserLoginData values)
        {
            if(_UserManager.RegisterUser(values.email, values.password))
                return Ok();
            return Unauthorized();
        }
    }
}
