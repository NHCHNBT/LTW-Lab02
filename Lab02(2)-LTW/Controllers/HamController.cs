using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02_2__LTW.Controllers
{
    public class HamController : Controller
    {
        // GET: Ham
        public ActionResult Index()
        {
            return View();
        }
    }
}