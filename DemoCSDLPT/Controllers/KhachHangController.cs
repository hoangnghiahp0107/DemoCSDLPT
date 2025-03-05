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
    }
}