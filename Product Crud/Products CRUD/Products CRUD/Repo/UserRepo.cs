using Products_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products_CRUD.Repo
{
    public class UserRepo
    {
         static ProductdbEntities db;

        static UserRepo()
        {
            db = new ProductdbEntities();
        }

        public static Customer Get(int cid)
        {
            var c = (from cus in db.Customers
                     where cus.id == cid
                     select cus).FirstOrDefault();
            return c;
        }

        public static Customer Authenticate(string name, string pass)
        {
            var c = (from cus in db.Customers
                     where cus.name == name && cus.password==pass
                     select cus).FirstOrDefault();
            return c;
        }


    }
} 