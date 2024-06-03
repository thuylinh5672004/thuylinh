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
            new DTLProduct{ID = 221090036,dtlFullName="thùy linh", dtlImage="anh",  dtlQuantity=23,dtlPrice =12000, dtlisActive='8'},
            new DTLProduct{ID = 221090037,dtlFullName="thùy thảo", dtlImage="anh",  dtlQuantity=27,dtlPrice =15000, dtlisActive='6'},

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