using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlLesson08CF.Models;

namespace DtlLesson08CF.Controllers
{
    public class DtlBooksController : Controller
    {
        private DtlBookStore db = new DtlBookStore();

        // GET: DtlBooks
        public ActionResult DtlIndex()
        {
            var dtlBooks = db.DtlBooks.Include(d => d.DtlCategory);
            return View(dtlBooks.ToList());
        }

        // GET: DtlBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlBook dtlBook = db.DtlBooks.Find(id);
            if (dtlBook == null)
            {
                return HttpNotFound();
            }
            return View(dtlBook);
        }

        // GET: DtlBooks/Create
        public ActionResult Create()
        {
            ViewBag.DtlCategoryId = new SelectList(db.DtlCategories, "DtlCategoryId", "DtlCategoryId");
            return View();
        }

        // POST: DtlBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DtlBookId,DtlTitle,DtlAuthor,DtlYear,DtlPublisher,DtlPicture,DtlCategoryId")] DtlBook dtlBook)
        {
            if (ModelState.IsValid)
            {
                db.DtlBooks.Add(dtlBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DtlCategoryId = new SelectList(db.DtlCategories, "DtlCategoryId", "DtlCategoryId", dtlBook.DtlCategoryId);
            return View(dtlBook);
        }

        // GET: DtlBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlBook dtlBook = db.DtlBooks.Find(id);
            if (dtlBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.DtlCategoryId = new SelectList(db.DtlCategories, "DtlCategoryId", "DtlCategoryId", dtlBook.DtlCategoryId);
            return View(dtlBook);
        }

        // POST: DtlBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DtlBookId,DtlTitle,DtlAuthor,DtlYear,DtlPublisher,DtlPicture,DtlCategoryId")] DtlBook dtlBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DtlCategoryId = new SelectList(db.DtlCategories, "DtlCategoryId", "DtlCategoryId", dtlBook.DtlCategoryId);
            return View(dtlBook);
        }

        // GET: DtlBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlBook dtlBook = db.DtlBooks.Find(id);
            if (dtlBook == null)
            {
                return HttpNotFound();
            }
            return View(dtlBook);
        }

        // POST: DtlBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DtlBook dtlBook = db.DtlBooks.Find(id);
            db.DtlBooks.Remove(dtlBook);
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
