using Dtl2210900036.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson11Dbs.Controllers
{
    public class HomeController : Controller
    {
        LoginModel db = new LoginModel();
        public ActionResult Index()
        {
            return View();
        }
        //HTTP Post/Home/Dangki
        public ActionResult Dangki ()
        {
            return View();
        }
        //HTTP Post/Home/Dangki
        [HttpPost]
        public ActionResult Dangki(DtlTaiKhoan DtlTaiKhoan)
        {
            db.DtlTaiKhoan.Add(DtlTaiKhoan);
            db.SaveChanges();
            return RedirectToAction("Dangnhap");
        }
        //HTTP Post/Home/Dangnhap
        public ActionResult Dangnhap()
        {
            return View();
        }
        //HTTP Post/Home/Dangnhap
        [HttpPost]
        public ActionResult Dangnhap(DtlTaiKhoan DtlTaiKhoan)
        {
            var IdFrom = DtlTaiKhoan.DtlId;
            var NameFrom = DtlTaiKhoan.DtlFullName;
            var matkhauFrom = DtlTaiKhoan.DtlPassword ;
            var emailFrom = DtlTaiKhoan.DtlEmail;
            var check = db.DtlTaiKhoan.SingleOrDefault(x=>x.DtlId.Equals(IdFrom)&& x.DtlFullName.Equals(NameFrom)&& x.DtlPassword.Equals(matkhauFrom)&& x.DtlEmail.Equals(emailFrom));
            if(check !=null)
            {
                Session["DtlTaiKhoan"] = check;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginFail = " Đăng nhập thất bại, vui lòng kiểm tra lại!";
                return View("Dangnhap");
            }
           
        }
        //HTTP Post/Home/Dangxuat
       
        public ActionResult Dangxuat()
        {
            Session["DtlTaiKhoan"] = null;
            return RedirectToAction("Index","Home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}