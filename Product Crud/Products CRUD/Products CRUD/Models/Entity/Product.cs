using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products_CRUD.Models.Entity
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string quantity {get; set; }
        public string description { get; set; }

    }
}