using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaTest.Areas.Blogs.Controllers
{
    public class PagesController : Controller
    {
        // GET: Blogs/Pages
        public ActionResult Index()
        {
            ViewBag.Name = "Page 1";
            return View();
        }
    }
}