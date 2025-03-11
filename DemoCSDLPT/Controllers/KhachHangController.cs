using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoCSDLPT.Models;

namespace DemoCSDLPT.Controllers
{
    public class KhachHangController : Controller
    {
        public JsonResult Index()
        {
            DataModel db = new DataModel();
            String sql = "EXEC DULIEUKHACHHANG";
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
        public JsonResult manh1()
        {
            DataModel db = new DataModel();
            string sql = "SELECT * FROM KHACHHANG_MANH1;";
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
        public JsonResult manh2()
        {
            DataModel db = new DataModel();
            string sql = "SELECT * FROM KHACHHANG_MANH2;";
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
    }
}