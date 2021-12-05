using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PaddleApp.Models;

namespace PaddleApp.Controllers
{
    public class PaddlesController : Controller
    {
        private PaddleContext db = new PaddleContext();

        // GET: Paddles
        public ActionResult Index()
        {
            return View(db.Location.ToList());
        }

        // GET: Paddles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paddle paddle = db.Location.Find(id);
            if (paddle == null)
            {
                return HttpNotFound();
            }
            return View(paddle);
        }

        // GET: Paddles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paddles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "loc_id,location")] Paddle paddle)
        {
            if (ModelState.IsValid)
            {
                db.Location.Add(paddle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paddle);
        }

        // GET: Paddles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paddle paddle = db.Location.Find(id);
            if (paddle == null)
            {
                return HttpNotFound();
            }
            return View(paddle);
        }

        // POST: Paddles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "loc_id,location")] Paddle paddle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paddle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paddle);
        }

        // GET: Paddles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paddle paddle = db.Location.Find(id);
            if (paddle == null)
            {
                return HttpNotFound();
            }
            return View(paddle);
        }

        // POST: Paddles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Paddle paddle = db.Location.Find(id);
            db.Location.Remove(paddle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
