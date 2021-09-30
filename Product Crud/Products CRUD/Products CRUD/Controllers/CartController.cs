using Products_CRUD.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Products_CRUD.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            if (Session["cart"] != null)
            {
                var items = Session["cart"].ToString();
                products = new JavaScriptSerializer().Deserialize<List<Product>>(items);

            }


            return View(products);
        }
    }
}