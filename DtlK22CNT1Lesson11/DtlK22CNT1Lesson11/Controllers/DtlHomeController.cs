using DtlK22CNT1Lesson11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlK22CNT1Lesson11.Controllers
{
    public class DtlHomeController : Controller
    {
        public ActionResult DtlIndex()
        {
            // lấy thông tin từ session
            //ViewBag["tvcTaiKhoan"] = "";
            if (Session["DtlMember"] != null)
            {
                ViewBag.dtlTaiKhoan = ((DtlTaiKhoan)Session["DtlMember"]).DtlFullName;
            }
            return View();
        }

        public ActionResult DtlAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DtlContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}