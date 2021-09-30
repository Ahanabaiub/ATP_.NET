using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Products_CRUD.Models.Entity;


namespace Products_CRUD.Models.Table
{
    public class Products
    {
        SqlConnection conn;
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void Add(Product p)
        {
            string query = String.Format("Insert into products values ('{0}','{1}','{2}','{3}')", p.name, p.price, p.quantity, p.description);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
           
            conn.Close();

        }

        public Product Get(int id)
        {

            string query = String.Format("select * from products where id = {0}",id);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Product p = new Product()
            {
                id = reader.GetInt32(reader.GetOrdinal("id")),
                name = reader.GetString(reader.GetOrdinal("name")),
                price = reader.GetString(reader.GetOrdinal("price")),
                quantity = reader.GetString(reader.GetOrdinal("quantity")),
                description = reader.GetString(reader.GetOrdinal("description"))
            };

            conn.Close();

            return p;
        }

        public List<Product> GetAll()
        {
            string query = "select * from products";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product p = new Product()
                {
                    id = reader.GetInt32(reader.GetOrdinal("id")),
                    name = reader.GetString(reader.GetOrdinal("name")),
                    price =reader.GetString(reader.GetOrdinal("price")),
                    quantity = reader.GetString(reader.GetOrdinal("quantity")),
                    description  = reader.GetString(reader.GetOrdinal("description"))
                };

                products.Add(p);
            }

            conn.Close();

            return products;
        }
    }
}