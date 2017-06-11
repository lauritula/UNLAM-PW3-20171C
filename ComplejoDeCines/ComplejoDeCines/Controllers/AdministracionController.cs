using ComplejoDeCines.Models;
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
        public ActionResult Inicio()
        {
            var modelo = new LoginAdministradorModels(); 
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Inicio(LoginAdministradorModels dato)
        {
            if (ModelState.IsValid)
                return RedirectToAction("MenuPrincipal", "Administracion");

            return View(dato);
        }

        public ActionResult MenuPrincipal()
        {
            return View();
        }

        public ActionResult Peliculas()
        {
            return View();
        }
        public ActionResult CrearPelicula()
        {
            return View();
        }
        public ActionResult Sedes()
        {
            return View();
        }
        public ActionResult CrearSede()
        {
            return View();
        }
        public ActionResult ModificarSede()
        {
            return View();
        }
        public ActionResult Reportes()
        {
            return View();
        }
        public ActionResult Carteleras()
        {
            return View();
        }
        public ActionResult CrearCartelera()
        {
            return View();
        }
        public ActionResult ModificarCartelera()
        {
            return View();
        }
        public ActionResult EliminarCartelera()
        {
            return View();
        }
    }
}