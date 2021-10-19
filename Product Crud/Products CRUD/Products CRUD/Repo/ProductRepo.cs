using Products_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products_CRUD.Repo
{
    public class ProductRepo
    {

        static ProductdbEntities db;

        static ProductRepo()
        {
            db = new ProductdbEntities();
        }

        public static Product Get(int id)
        {
            var p = db.Products.FirstOrDefault(e => e.id == id);

            return p;
        }
    }
}