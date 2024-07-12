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
    public class TacgiasController : Controller
    {
        private daothithuylinh_2210900036Entities db = new daothithuylinh_2210900036Entities();

        // GET: Tacgias
        public ActionResult DtlIndex()
        {
            return View(db.Tacgia.ToList());
        }

        // GET: Tacgias/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tacgia tacgia = db.Tacgia.Find(id);
            if (tacgia == null)
            {
                return HttpNotFound();
            }
            return View(tacgia);
        }

        // GET: Tacgias/Create
        public ActionResult DtlCreate()
        {
            return View();
        }

        // POST: Tacgias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlMaTG,DtlTenTG")] Tacgia tacgia)
        {
            if (ModelState.IsValid)
            {
                db.Tacgia.Add(tacgia);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            return View(tacgia);
        }

        // GET: Tacgias/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tacgia tacgia = db.Tacgia.Find(id);
            if (tacgia == null)
            {
                return HttpNotFound();
            }
            return View(tacgia);
        }

        // POST: Tacgias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlMaTG,DtlTenTG")] Tacgia tacgia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tacgia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            return View(tacgia);
        }

        // GET: Tacgias/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tacgia tacgia = db.Tacgia.Find(id);
            if (tacgia == null)
            {
                return HttpNotFound();
            }
            return View(tacgia);
        }

        // POST: Tacgias/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tacgia tacgia = db.Tacgia.Find(id);
            db.Tacgia.Remove(tacgia);
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
