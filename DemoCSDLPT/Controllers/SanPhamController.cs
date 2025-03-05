using DemoCSDLPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCSDLPT.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public JsonResult Index()
        {
            DataModel db = new DataModel();
            String sql = "SELECT * FROM sanpham";
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
        public JsonResult manh1()
        {
            DataModel db = new DataModel();
            string sql = "SELECT * FROM SANPHAM_MANH1;";
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
        public JsonResult manh2()
        {
            DataModel db = new DataModel();
            string sql = "SELECT * FROM SANPHAM_MANH2;";
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
    }
}