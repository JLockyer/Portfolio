using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_FinalProject;

namespace Portfolio_FinalProject.Models
{
    public class ApplicationTypesController : Controller
    {
        private Portfolio_DBEntities db = new Portfolio_DBEntities();

        // GET: ApplicationTypes
        public ActionResult Index()
        {
            return View(db.ApplicationTypes.ToList());
        }

        // GET: ApplicationTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            if (applicationType == null)
            {
                return HttpNotFound();
            }
            return View(applicationType);
        }

        // GET: ApplicationTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeID,AppType")] ApplicationType applicationType)
        {
            if (ModelState.IsValid)
            {
                db.ApplicationTypes.Add(applicationType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicationType);
        }

        // GET: ApplicationTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            if (applicationType == null)
            {
                return HttpNotFound();
            }
            return View(applicationType);
        }

        // POST: ApplicationTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeID,AppType")] ApplicationType applicationType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicationType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicationType);
        }

        // GET: ApplicationTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            if (applicationType == null)
            {
                return HttpNotFound();
            }
            return View(applicationType);
        }

        // POST: ApplicationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            db.ApplicationTypes.Remove(applicationType);
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
