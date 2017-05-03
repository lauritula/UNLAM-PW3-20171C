using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplejoDeCines.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult reserva()
        {
            return View();
        }
        public ActionResult confirmacion()
        {
            return View();
        }
    }
}