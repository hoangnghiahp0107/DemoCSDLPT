using DemoCSDLPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoCSDLPT.Controllers
{
    public class HoaDonController : Controller
    {
        // GET: HoaDon
        public JsonResult Index()
        {
            DataModel db = new DataModel();
            String sql = "EXEC DULIEUHOADON";
            return Json(db.get(sql), JsonRequestBehavior.AllowGet);
        }
    }
}