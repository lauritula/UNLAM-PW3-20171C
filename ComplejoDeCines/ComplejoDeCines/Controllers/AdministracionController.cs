using ComplejoDeCines.Models;
using System.Web.Mvc;
using ComplejoDeCines;
using System.Linq;
using System;
using System.IO;
using static System.Net.WebRequestMethods;

namespace ComplejoDeCines.Controllers
{
    public class AdministracionController : Controller
    {
        CineDB contexto;
        public AdministracionController()
        {
            contexto = new CineDB();
          
        }

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
            ViewBag.generos = contexto.Generos.ToList();
            ViewBag.calificaciones = contexto.Calificaciones.ToList();
            return View();

        }

        [HttpPost]
        public ActionResult CrearPelicula(Pelicula pelicula)
        {

            contexto.Peliculas.Add(pelicula);
            contexto.SaveChanges();
            return RedirectToAction("MenuPrincipal", "Administracion");
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