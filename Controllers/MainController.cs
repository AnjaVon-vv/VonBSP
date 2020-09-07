using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VonBSP.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Search()
        {


            return View();
        }
     

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }
    }
}