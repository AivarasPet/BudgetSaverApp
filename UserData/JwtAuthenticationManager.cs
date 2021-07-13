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
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {

        private readonly string key;
        private DboContext DboContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JwtAuthenticationManager(DboContext dboContext, IHttpContextAccessor httpContextAccessor) //, AuthTokenStringHolder authTokenStringHolder
        {
            this.key = "aaaa[aa]aa[aa]aa";
            DboContext = dboContext;
            _httpContextAccessor = httpContextAccessor;
        }
        public string AuthenticateUser(string email, string password)
        {
            //if (!DboContext.Users.Any(u => u.email == email && password == u.password)) return null;
            User user = DboContext.Users.Where(x => x.email.ToLower() == email.ToLower()).FirstOrDefault();
            if (user == null) return null; 

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            Claim[] claims = new Claim[] { new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()) };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
            

        }

        public int GetUserID()
        {
            return int.Parse(_httpContextAccessor.HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
        }
    }
}
