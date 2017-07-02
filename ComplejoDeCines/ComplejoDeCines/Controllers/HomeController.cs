using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplejoDeCines.Controllers
{
    public class HomeController : Controller
    {
        CineDB contexto;
        public HomeController()
        {
            contexto = new CineDB();

        }
        // GET: Home
        public ActionResult Inicio()
        {
            var dato = from peliculas in contexto.Peliculas
                       select peliculas;

            return View(dato);
        }
    }
}