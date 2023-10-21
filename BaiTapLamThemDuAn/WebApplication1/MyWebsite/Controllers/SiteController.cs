using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myclass.Models;

namespace MyWebsite.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            MyDBContent myDB = new MyDBContent();

            int soKhachHang = 1;//myDB.hoadons.Count();
            ViewBag.SoKhachHang = soKhachHang;
            return View();
        }

    }
}