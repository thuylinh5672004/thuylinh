using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlK22CNT1Lesson11.Models;

namespace DtlK22CNT1Lesson11.Controllers
{
    public class DtlTaiKhoansController : Controller
    {
        private DtlLesson11DbsEntities2 db = new DtlLesson11DbsEntities2();

        // GET: DtlTaiKhoans
        public ActionResult Index()
        {
            return View(db.DtlTaiKhoan.ToList());
        }

        // GET: DtlTaiKhoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlTaiKhoan dtlTaiKhoan = db.DtlTaiKhoan.Find(id);
            if (dtlTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(dtlTaiKhoan);
        }

        // GET: DtlTaiKhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DtlTaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DtlId,DtlUserName,DtlPassword,DtlFullName,DtlAge,DtlEmail,DtlPhone,DtlStatus")] DtlTaiKhoan dtlTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.DtlTaiKhoan.Add(dtlTaiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dtlTaiKhoan);
        }

        // GET: DtlTaiKhoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlTaiKhoan dtlTaiKhoan = db.DtlTaiKhoan.Find(id);
            if (dtlTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(dtlTaiKhoan);
        }

        // POST: DtlTaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DtlId,DtlUserName,DtlPassword,DtlFullName,DtlAge,DtlEmail,DtlPhone,DtlStatus")] DtlTaiKhoan dtlTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlTaiKhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dtlTaiKhoan);
        }

        // GET: DtlTaiKhoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlTaiKhoan dtlTaiKhoan = db.DtlTaiKhoan.Find(id);
            if (dtlTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(dtlTaiKhoan);
        }

        // POST: DtlTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DtlTaiKhoan dtlTaiKhoan = db.DtlTaiKhoan.Find(id);
            db.DtlTaiKhoan.Remove(dtlTaiKhoan);
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
