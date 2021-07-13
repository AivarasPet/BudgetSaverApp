using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp.UserData
{
    public interface IJwtAuthenticationManager
    {
        public string AuthenticateUser(string email, string password);
        public int GetUserID();
    }
}
