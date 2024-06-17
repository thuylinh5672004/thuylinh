
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlBaiKiemTraGK.Models;

namespace DtlBaiKiemTraGK.Controllers
{
    public class dtlKhoasController : Controller
    {
        private DtlK22CNT1Lesson07DbEntities db = new DtlK22CNT1Lesson07DbEntities();

        // GET: dtlKhoas
        public ActionResult DtlIndex()
        {
            return View(db.dtlKhoa.ToList());
        }

        // GET: dtlKhoas/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlKhoa dtlKhoa = db.dtlKhoa.Find(id);
            if (dtlKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtlKhoa);
        }

        // GET: dtlKhoas/Create
        public ActionResult DtlCreate()
        {
            return View();
        }

        // POST: dtlKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlMaKH,DtlTenKH,DtlTrangThai")] dtlKhoa dtlKhoa)
        {
            if (ModelState.IsValid)
            {
                db.dtlKhoa.Add(dtlKhoa);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            return View(dtlKhoa);
        }

        // GET: dtlKhoas/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlKhoa dtlKhoa = db.dtlKhoa.Find(id);
            if (dtlKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtlKhoa);
        }

        // POST: dtlKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlMaKH,DtlTenKH,DtlTrangThai")] dtlKhoa dtlKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            return View(dtlKhoa);
        }

        // GET: dtlKhoas/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlKhoa dtlKhoa = db.dtlKhoa.Find(id);
            if (dtlKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtlKhoa);
        }

        // POST: dtlKhoas/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dtlKhoa dtlKhoa = db.dtlKhoa.Find(id);
            db.dtlKhoa.Remove(dtlKhoa);
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
