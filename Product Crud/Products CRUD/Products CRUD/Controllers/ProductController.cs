using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Products_CRUD.Models.Entity;
using Products_CRUD.Models;
using System.Net.Http;
using System.Net;
using System.Web.Script.Serialization;

namespace Products_CRUD.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Database db = new Database();
            var products = db.products.GetAll();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {

            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.products.Add(p);
                return RedirectToAction("Index");
            }

          

            return View();
        }

        [HttpGet]
        public ActionResult Addtocart(string id)
        {
            
            //return RedirectToAction("Index");

            Database db = new Database();

            Product p = db.products.Get(Int32.Parse(id));

            List<Product> products = new List<Product>();



            if (Session["cart"] == null)
            {
                products.Add(p);
                var json = new JavaScriptSerializer().Serialize(p);
                Session["cart"] = json;
            }
            else
            {
                var items = Session["cart"].ToString();
                products = new JavaScriptSerializer().Deserialize<List<Product>>(items);
                products.Add(p);
                var json = new JavaScriptSerializer().Serialize(products);
                Session["cart"] = json;
            }
           
            

            return RedirectToAction("Index");
        }
    }

}