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
        public ActionResult crearPelicula()
        {
            return View();
        }
        public ActionResult sedes()
        {
            return View();
        }
        public ActionResult crearSede()
        {
            return View();
        }
        public ActionResult modificarSede()
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
        public ActionResult crearCartelera()
        {
            return View();
        }
        public ActionResult modificarCartelera()
        {
            return View();
        }
        public ActionResult eliminarCartelera()
        {
            return View();
        }
    }
}