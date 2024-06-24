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
    public class KetQuasController : Controller
    {
        private DtlK22CNT1Lesson10Entities db = new DtlK22CNT1Lesson10Entities();

        // GET: KetQuas
        public ActionResult DtlIndex()
        {
            var ketQua = db.KetQua.Include(k => k.MonHoc).Include(k => k.Sinhvien);
            return View(ketQua.ToList());
        }

        // GET: KetQuas/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KetQua ketQua = db.KetQua.Find(id);
            if (ketQua == null)
            {
                return HttpNotFound();
            }
            return View(ketQua);
        }

        // GET: KetQuas/Create
        public ActionResult DtlCreate()
        {
            ViewBag.DtlMaSV = new SelectList(db.MonHoc, "DtlMaMH", "DtlTenMH");
            ViewBag.DtlMaSV = new SelectList(db.Sinhvien, "DtlMaSV", "DtlHoSV");
            return View();
        }

        // POST: KetQuas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlMaSV,DtlMaMH,DtlDiem")] KetQua ketQua)
        {
            if (ModelState.IsValid)
            {
                db.KetQua.Add(ketQua);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.DtlMaSV = new SelectList(db.MonHoc, "DtlMaMH", "DtlTenMH", ketQua.DtlMaSV);
            ViewBag.DtlMaSV = new SelectList(db.Sinhvien, "DtlMaSV", "DtlHoSV", ketQua.DtlMaSV);
            return View(ketQua);
        }

        // GET: KetQuas/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KetQua ketQua = db.KetQua.Find(id);
            if (ketQua == null)
            {
                return HttpNotFound();
            }
            ViewBag.DtlMaSV = new SelectList(db.MonHoc, "DtlMaMH", "DtlTenMH", ketQua.DtlMaSV);
            ViewBag.DtlMaSV = new SelectList(db.Sinhvien, "DtlMaSV", "DtlHoSV", ketQua.DtlMaSV);
            return View(ketQua);
        }

        // POST: KetQuas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlMaSV,DtlMaMH,DtlDiem")] KetQua ketQua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ketQua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DtlMaSV = new SelectList(db.MonHoc, "DtlMaMH", "DtlTenMH", ketQua.DtlMaSV);
            ViewBag.DtlMaSV = new SelectList(db.Sinhvien, "DtlMaSV", "DtlHoSV", ketQua.DtlMaSV);
            return View(ketQua);
        }

        // GET: KetQuas/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KetQua ketQua = db.KetQua.Find(id);
            if (ketQua == null)
            {
                return HttpNotFound();
            }
            return View(ketQua);
        }

        // POST: KetQuas/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KetQua ketQua = db.KetQua.Find(id);
            db.KetQua.Remove(ketQua);
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
