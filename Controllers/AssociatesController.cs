using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using themeIntegrationMvc.Models;

namespace themeIntegrationMvc.Controllers
{
    public class AssociatesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Associates
        public ActionResult Index()
        {
            return View(db.Associates.ToList());
        }

        // GET: Associates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Associate associate = db.Associates.Find(id);
            if (associate == null)
            {
                return HttpNotFound();
            }
            return View(associate);
        }

        // GET: Associates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Associates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,email,phone,location")] Associate associate)
        {
            if (ModelState.IsValid)
            {
                db.Associates.Add(associate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(associate);
        }

        // GET: Associates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Associate associate = db.Associates.Find(id);
            if (associate == null)
            {
                return HttpNotFound();
            }
            return View(associate);
        }

        // POST: Associates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,email,phone,location")] Associate associate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(associate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(associate);
        }

        // GET: Associates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Associate associate = db.Associates.Find(id);
            if (associate == null)
            {
                return HttpNotFound();
            }
            return View(associate);
        }

        // POST: Associates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Associate associate = db.Associates.Find(id);
            db.Associates.Remove(associate);
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
