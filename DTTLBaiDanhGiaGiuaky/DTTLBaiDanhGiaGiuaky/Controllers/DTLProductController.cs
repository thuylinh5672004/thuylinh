using DTTLBaiDanhGiaGiuaky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTTLBaiDanhGiaGiuaky.Controllers
{
    public class DTLProductController : Controller
    {
        private static List<DTLProduct> dTLProducts = new List<DTLProduct>()

        {
            new DTLProduct{dtlID = 5,dtlFullName="thùy linh", dtlImage="imageA.jpg",  dtlQuantity=23,dtlPrice =12000, dtlisActive=true},
            new DTLProduct{dtlID = 6,dtlFullName="thùy thảo", dtlImage="imageB.jpg",  dtlQuantity=27,dtlPrice =15000, dtlisActive=true}

        };
        // GET: DTL


        public ActionResult Index()
        {
            return View(dTLProducts);
        }
        public ActionResult DTLCreate()
        {
            var dtlProduct = new DTLProduct();
            return View(dtlProduct);
        }
        // GET: DTL
        [HttpPost]
        public ActionResult DTLCreate(DTLProduct dtlProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(dtlProduct);
            }
            //nếu dữ liệu đúng thì lưu vào danh sách
            dTLProducts.Add(dtlProduct);
            return RedirectToAction("Index");
        }
    }
}
