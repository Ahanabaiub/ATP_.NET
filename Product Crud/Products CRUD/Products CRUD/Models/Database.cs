using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Products_CRUD.Models.Table;

using System.Linq;
using System.Web;

namespace Products_CRUD.Models
{
    public class Database
    {

        public Products products { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-3O7GHJ3\SQLEXPRESS;Database=Productdb;Integrated Security=true";

            SqlConnection conn = new SqlConnection(connString);
            products = new Products(conn);

        }
    }
}