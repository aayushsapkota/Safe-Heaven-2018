using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Safe_Heaven_2018.Models;

namespace Safe_Heaven_2018.Controllers
{
    public class allowedTimesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: allowedTimes
        public ActionResult Index()
        {
            var allowedTimes = db.allowedTimes.Include(a => a.Players);
            return View(allowedTimes.ToList());
        }

        // GET: allowedTimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            allowedTime allowedTime = db.allowedTimes.Find(id);
            if (allowedTime == null)
            {
                return HttpNotFound();
            }
            return View(allowedTime);
        }

        // GET: allowedTimes/Create
        public ActionResult Create()
        {
            ViewBag.playerId = new SelectList(db.Players, "playerId", "Username");
            return View();
        }

        // POST: allowedTimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,time,playerId")] allowedTime allowedTime)
        {
            if (ModelState.IsValid)
            {
                db.allowedTimes.Add(allowedTime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.playerId = new SelectList(db.Players, "playerId", "Username", allowedTime.playerId);
            return View(allowedTime);
        }

        // GET: allowedTimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            allowedTime allowedTime = db.allowedTimes.Find(id);
            if (allowedTime == null)
            {
                return HttpNotFound();
            }
            ViewBag.playerId = new SelectList(db.Players, "playerId", "Username", allowedTime.playerId);
            return View(allowedTime);
        }

        // POST: allowedTimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,time,playerId")] allowedTime allowedTime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allowedTime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.playerId = new SelectList(db.Players, "playerId", "Username", allowedTime.playerId);
            return View(allowedTime);
        }

        // GET: allowedTimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            allowedTime allowedTime = db.allowedTimes.Find(id);
            if (allowedTime == null)
            {
                return HttpNotFound();
            }
            return View(allowedTime);
        }

        // POST: allowedTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            allowedTime allowedTime = db.allowedTimes.Find(id);
            db.allowedTimes.Remove(allowedTime);
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
