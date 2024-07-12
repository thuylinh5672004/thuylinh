using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson11Dbs.Models;

namespace Lesson11Dbs.Controllers
{
    public class SachsController : Controller
    {
        private daothithuylinh_2210900036Entities db = new daothithuylinh_2210900036Entities();

        // GET: Sachs
        public ActionResult DtlIndex()
        {
            var sach = db.Sach.Include(s => s.Tacgia);
            return View(sach.ToList());
        }

        // GET: Sachs/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Sach.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // GET: Sachs/Create
        public ActionResult DtlCreate()
        {
            ViewBag.DtlMaTG = new SelectList(db.Tacgia, "DtlMaTG", "DtlTenTG");
            return View();
        }

        // POST: Sachs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlMaSach,DtlTenSach,DtlSoTrang,DtlNamXB,DtlMaTG,DtlTrangThai")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                db.Sach.Add(sach);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.DtlMaTG = new SelectList(db.Tacgia, "DtlMaTG", "DtlTenTG", sach.DtlMaTG);
            return View(sach);
        }

        // GET: Sachs/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Sach.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.DtlMaTG = new SelectList(db.Tacgia, "DtlMaTG", "DtlTenTG", sach.DtlMaTG);
            return View(sach);
        }

        // POST: Sachs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlMaSach,DtlTenSach,DtlSoTrang,DtlNamXB,DtlMaTG,DtlTrangThai")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            ViewBag.DtlMaTG = new SelectList(db.Tacgia, "DtlMaTG", "DtlTenTG", sach.DtlMaTG);
            return View(sach);
        }

        // GET: Sachs/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Sach.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // POST: Sachs/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Sach sach = db.Sach.Find(id);
            db.Sach.Remove(sach);
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
