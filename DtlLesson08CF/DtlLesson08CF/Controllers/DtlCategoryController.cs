using DtlLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlLesson08CF.Controllers
{
    public class DtlCategoryController : Controller
    {
        private static DtlBookStore _DtlBookStore;
        public DtlCategoryController()
        {
            _DtlBookStore = new DtlBookStore();
        }
        // GET: DtlCategory
        public ActionResult DtlIndex()
        {
            var dtlCategory = _DtlBookStore.DtlCategories.ToList();
            
            return View(dtlCategory);
        }
        [HttpGet]
        public ActionResult DtlCreate()
        {
            var dtlCategory =new DtlCategory();
            return View(dtlCategory);
        }
        [HttpPost]
        public ActionResult DtlCreate(DtlCategory dtlCategory)
        {
            _DtlBookStore.DtlCategories.Add(dtlCategory);
            _DtlBookStore.SaveChanges();
            return RedirectToAction("DtlIndex");
        }
    }
}