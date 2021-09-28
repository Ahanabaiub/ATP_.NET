using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Products_CRUD.Models.Entity;
using Products_CRUD.Models;

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

            Database db = new Database();
            db.products.Add(p);
            return RedirectToAction("Index");

            return View();
        }
    }

}