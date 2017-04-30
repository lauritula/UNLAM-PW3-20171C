using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplejoDeCines.Controllers
{
    public class AdministracionController : Controller
    {
        // GET: Administracion
        public ActionResult inicio()
        {
            return View();
        }

        public ActionResult menuPrincipal()
        {
            return View();
        }
        public ActionResult peliculas()
        {
            return View();
        }
        public ActionResult sedes()
        {
            return View();
        }
        public ActionResult reportes()
        {
            return View();
        }
        public ActionResult carteleras()
        {
            return View();
        }
    }
}