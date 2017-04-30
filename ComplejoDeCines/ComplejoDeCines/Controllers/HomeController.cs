using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplejoDeCines.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult inicio()
        {
            return View();
        }
    }
}