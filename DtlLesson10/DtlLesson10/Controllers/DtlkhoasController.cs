using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlLesson10.Models;

namespace DtlLesson10.Controllers
{
    public class DtlkhoasController : Controller
    {
        private DtlK22CNT1Lesson10Entities db = new DtlK22CNT1Lesson10Entities();

        // GET: Dtlkhoas
        public ActionResult DtlIndex()
        {
            return View(db.khoa.ToList());
        }

        // GET: Dtlkhoas/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khoa khoa = db.khoa.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // GET: Dtlkhoas/Create
        public ActionResult DtlCreate()
        {
            return View();
        }

        // POST: Dtlkhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlMaKH,DtlTenKH")] khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.khoa.Add(khoa);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            return View(khoa);
        }

        // GET: Dtlkhoas/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khoa khoa = db.khoa.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // POST: Dtlkhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlMaKH,DtlTenKH")] khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            return View(khoa);
        }

        // GET: Dtlkhoas/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khoa khoa = db.khoa.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // POST: Dtlkhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            khoa khoa = db.khoa.Find(id);
            db.khoa.Remove(khoa);
            db.SaveChanges();
            return RedirectToAction("DtlIndex");
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
