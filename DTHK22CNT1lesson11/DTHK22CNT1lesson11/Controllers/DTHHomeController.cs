using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTHK22CNT1lesson11.Models;

namespace DTHK22CNT1lesson11.Controllers
{
    public class DTHHomeController : Controller
    {
        // GET: DTHHome
        public ActionResult DthIndex()
        {
            // lấy thông tin từ session
            //ViewBag["NvtTaiKhoan"] = "";
            if (Session["DthMember"] != null)
            {
                ViewBag.DthTaiKhoan = ((DthTaikhoan)Session["DthMember"]).DthFullName;
            }
            return View();
        }

        public ActionResult DthAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DthContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}