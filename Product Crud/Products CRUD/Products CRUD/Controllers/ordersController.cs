using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Products_CRUD;
using Products_CRUD.Models;

namespace Products_CRUD.Controllers
{
    public class ordersController : Controller
    {
        private ProductdbEntities db = new ProductdbEntities();

     
        public ActionResult Index()
        {
            var orders = db.orders.Include(o => o.orderDetail).Include(o => o.orders1).Include(o => o.order1);
            return View(orders.ToList());
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            order order = db.orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        public ActionResult Create()
        {
            ViewBag.id = new SelectList(db.orderDetails, "id", "id");
            ViewBag.id = new SelectList(db.orders, "id", "id");
            ViewBag.id = new SelectList(db.orders, "id", "id");
            return View();
        }

        [HttpPost]
     
        public ActionResult Create([Bind(Include = "id,customer_id")] order order)
        {
            if (ModelState.IsValid)
            {
                db.orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id = new SelectList(db.orderDetails, "id", "id", order.id);
            ViewBag.id = new SelectList(db.orders, "id", "id", order.id);
            ViewBag.id = new SelectList(db.orders, "id", "id", order.id);
            return View(order);
        }

   
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            order order = db.orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.id = new SelectList(db.orderDetails, "id", "id", order.id);
            ViewBag.id = new SelectList(db.orders, "id", "id", order.id);
            ViewBag.id = new SelectList(db.orders, "id", "id", order.id);
            return View(order);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,customer_id")] order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id = new SelectList(db.orderDetails, "id", "id", order.id);
            ViewBag.id = new SelectList(db.orders, "id", "id", order.id);
            ViewBag.id = new SelectList(db.orders, "id", "id", order.id);
            return View(order);
        }

     
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            order order = db.orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

     
    
    }
}
