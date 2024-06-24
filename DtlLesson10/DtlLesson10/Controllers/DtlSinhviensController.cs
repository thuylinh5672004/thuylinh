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
    public class DtlSinhviensController : Controller
    {
        private DtlK22CNT1Lesson10Entities db = new DtlK22CNT1Lesson10Entities();

        // GET: DtlSinhviens
        public ActionResult DtlIndex()
        {
            var sinhvien = db.Sinhvien.Include(s => s.KetQua).Include(s => s.khoa);
            return View(sinhvien.ToList());
        }

        // GET: DtlSinhviens/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            return View(sinhvien);
        }

        // GET: DtlSinhviens/Create
        public ActionResult DtlCreate()
        {
            ViewBag.DtlMaSV = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH");
            ViewBag.DtlMaKH = new SelectList(db.khoa, "DtlMaKH", "DtlTenKH");
            return View();
        }

        // POST: DtlSinhviens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlMaSV,DtlHoSV,DtlTenSV,DtlPhai,DtlNgaysinh,DtlNoisinh,DtlMaKH,DtlHocBong,DtlDiemTB")] Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                db.Sinhvien.Add(sinhvien);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.DtlMaSV = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH", sinhvien.DtlMaSV);
            ViewBag.DtlMaKH = new SelectList(db.khoa, "DtlMaKH", "DtlTenKH", sinhvien.DtlMaKH);
            return View(sinhvien);
        }

        // GET: DtlSinhviens/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.DtlMaSV = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH", sinhvien.DtlMaSV);
            ViewBag.DtlMaKH = new SelectList(db.khoa, "DtlMaKH", "DtlTenKH", sinhvien.DtlMaKH);
            return View(sinhvien);
        }

        // POST: DtlSinhviens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlMaSV,DtlHoSV,DtlTenSV,DtlPhai,DtlNgaysinh,DtlNoisinh,DtlMaKH,DtlHocBong,DtlDiemTB")] Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            ViewBag.DtlMaSV = new SelectList(db.KetQua, "DtlMaSV", "DtlMaMH", sinhvien.DtlMaSV);
            ViewBag.DtlMaKH = new SelectList(db.khoa, "DtlMaKH", "DtlTenKH", sinhvien.DtlMaKH);
            return View(sinhvien);
        }

        // GET: DtlSinhviens/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            return View(sinhvien);
        }

        // POST: DtlSinhviens/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Sinhvien sinhvien = db.Sinhvien.Find(id);
            db.Sinhvien.Remove(sinhvien);
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
