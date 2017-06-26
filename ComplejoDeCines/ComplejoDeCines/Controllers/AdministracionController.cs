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

        /*20170624 -- VALIDA USUARIO POR BASE DE DATOS*/
        [HttpPost]
        public ActionResult Inicio(LoginAdministradorModels dato)
        {
            /*if (ModelState.IsValid)
                return RedirectToAction("MenuPrincipal", "Administracion");*/
            if (ModelState.IsValid)
            {
                var valor = contexto.Usuarios.Where(a => a.NombreUsuario.Equals(dato.Usuario) && a.Password.Equals(dato.Password)).FirstOrDefault();
                    if (valor != null)
                    {
                        Session["UserId"] = dato.UserId.ToString();
                        Session["UserName"] = dato.Usuario.ToString();
                        return RedirectToAction("MenuPrincipal", "Administracion");
                    }
            }
            return View(dato);
        }

        public ActionResult MenuPrincipal()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult Peliculas()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                var dato = from peliculas in contexto.Peliculas
                           select peliculas;

                return View(dato);
            }
            
        }

        public ActionResult CrearPelicula()
        {
            if (Session["UserId"] != null)
            {
                ViewBag.generos = contexto.Generos.ToList();
                ViewBag.calificaciones = contexto.Calificaciones.ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
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
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult CrearSede()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult ModificarSede()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult Reportes()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult Carteleras()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult CrearCartelera()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult ModificarCartelera()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }

        public ActionResult EliminarCartelera()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Administracion");
            }
        }
    }
}