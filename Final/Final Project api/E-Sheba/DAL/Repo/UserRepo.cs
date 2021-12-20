using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo : IUser<User, int>,IAuth
    {
        Entities db;
        public UserRepo(Entities db)
        {
            this.db = db;
        }

        public void Add(User e)
        {
            throw new NotImplementedException();
        }

        public Access_token Authenticate(User user)
        {
            var u = db.Users.Where(e =>  e.email.Trim() == user.email && e.password.Trim() == user.password).FirstOrDefault();
            Access_token access_token=null;
            if (u!=null)
            {
                access_token = new Access_token();
                string token = Guid.NewGuid().ToString();
                access_token.token = token;
                access_token.user_id = u.id;
                access_token.created_at = DateTime.Now;
                db.Access_token.Add(access_token);
                db.SaveChanges();
            }
            return access_token;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(User e)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated(string token)
        {
            var tkn = db.Access_token.Where(t => t.token == token).FirstOrDefault();
            if (tkn.expired_at == null)
            {
                return true;
            }

            return false;
        }

        public void Logout(string token)
        {
            var tkn =db.Access_token.Where(t => t.token == token).FirstOrDefault();
            tkn.expired_at = DateTime.Now;
            db.SaveChanges();
        }
    }
}
