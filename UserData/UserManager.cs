using BudgetSaverApp.Other;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BudgetSaverApp.UserData
{
    public class UserManager : IUserManager
    {

        private readonly string key;
        private DboContext DboContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserManager(DboContext dboContext, IHttpContextAccessor httpContextAccessor) //, AuthTokenStringHolder authTokenStringHolder
        {
            this.key = "aaaa[aa]aa[aa]aa";
            DboContext = dboContext;
            _httpContextAccessor = httpContextAccessor;
        }
        public string AuthenticateUser(string email, string password)
        {
            int userID = GetUserIDFromDatabase(email, password);
            if (userID == 0) return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            Claim[] claims = new Claim[] { new Claim(ClaimTypes.NameIdentifier, userID.ToString()) };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public bool RegisterUser(string email, string password)
        {
            if (GetUserIDFromDatabase(email, password) != 0) return false;
            DboContext.Users.Add(new User() { email = email, password = password });
            return true;
        }

        private int GetUserIDFromDatabase(string email, string password)
        {
            if (!DboContext.Users.Any(u => u.email == email && password == u.password)) return 0;
            User user = DboContext.Users.Where(x => x.email.ToLower() == email.ToLower()).FirstOrDefault();
            return user.ID;
        }
    }
}
