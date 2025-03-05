using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoCSDLPT.Models;

namespace DemoCSDLPT.Controllers
{
    public class ChiTietHoaDonController : Controller
    {
        // GET: ChiTietHoaDon
        public JsonResult index(string id)
        {
            if (id == null || id == "")
            {
                return Json("", JsonRequestBehavior.AllowGet); ;
            }
            DataModel db = new DataModel();
            string sql = "EXEC DULIEUCHITIETHOADON " + id;
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
    }
}