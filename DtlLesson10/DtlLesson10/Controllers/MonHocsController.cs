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
    public class MonHocsController : Controller
    {
        private DtlK22CNT1Lesson10Entities db = new DtlK22CNT1Lesson10Entities();

        // GET: MonHocs
        public ActionResult DtlIndex()
        {
            var monHoc = db.MonHoc.Include(m => m.KetQua);
            return View(monHoc.ToList());
        }

        // GET: MonHocs/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonHoc monHoc = db.MonHoc.Find(id);
            if (monHoc == null)
            {
                return HttpNotFound();
            }
            return View(monHoc);
        }

        // GET: MonHocs/Create
        public ActionResult DtlCreate()
        {
            ViewBag.DtlMaMH = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH");
            return View();
        }

        // POST: MonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlMaMH,DtlTenMH,DtlSoTiet")] MonHoc monHoc)
        {
            if (ModelState.IsValid)
            {
                db.MonHoc.Add(monHoc);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.DtlMaMH = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH", monHoc.DtlMaMH);
            return View(monHoc);
        }

        // GET: MonHocs/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonHoc monHoc = db.MonHoc.Find(id);
            if (monHoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.DtlMaMH = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH", monHoc.DtlMaMH);
            return View(monHoc);
        }

        // POST: MonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlMaMH,DtlTenMH,DtlSoTiet")] MonHoc monHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            ViewBag.DtlMaMH = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH", monHoc.DtlMaMH);
            return View(monHoc);
        }

        // GET: MonHocs/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonHoc monHoc = db.MonHoc.Find(id);
            if (monHoc == null)
            {
                return HttpNotFound();
            }
            return View(monHoc);
        }

        // POST: MonHocs/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MonHoc monHoc = db.MonHoc.Find(id);
            db.MonHoc.Remove(monHoc);
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
