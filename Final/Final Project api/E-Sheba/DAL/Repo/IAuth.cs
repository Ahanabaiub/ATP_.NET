using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public interface IAuth
    {
        Access_token Authenticate(User user);
        bool IsAuthenticated(string token);
        void Logout(string token);
    }
}
