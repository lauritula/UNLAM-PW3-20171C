using ComplejoDeCines.Models;
using System.Web.Mvc;
using ComplejoDeCines;
using System.Linq;
using System;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;

namespace ComplejoDeCines.Controllers
{
    public class AdministracionController : Controller
    {
        CineDB contexto = new CineDB();

        public AdministracionController()
        {
            //CineDB contexto = new CineDB();  
        }

        /*DONE*/public ActionResult Inicio()
        {
            var modelo = new LoginAdministradorModels(); 
            return View(modelo);
        }
        /*DONE*/[HttpPost] public ActionResult Inicio(LoginAdministradorModels dato)
        {
            if (ModelState.IsValid)
            {
                var valor = contexto.Usuarios.Where(a => a.NombreUsuario.Equals(dato.Usuario) && a.Password.Equals(dato.Password)).FirstOrDefault();
                    if (valor != null)
                        {
                            Session["UserId"] = dato.UserId.ToString();
                            Session["UserName"] = dato.Usuario.ToString();
                   if (Session["CurrentStatus"] != null)
                        {
                            var redirect = Session["CurrentStatus"].ToString();
                            Session["CurrentStatus"] = null;
                            return RedirectToAction(redirect, "Administracion");
                        }
                  else {
                            return RedirectToAction("MenuPrincipal", "Administracion");
                       } 
                    }
            }
            return View(dato);
        }
        /*DONE*/public ActionResult MenuPrincipal()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "MenuPrincipal";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        /*DONE*/public ActionResult Peliculas()
        {
            if (Session["UserId"] != null)
            {
                var peliculas = contexto.Peliculas.ToList();
                ViewBag.Peliculas = peliculas;
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "Peliculas";
                return RedirectToAction("Inicio", "Administracion");
            }
        }


        public ActionResult NuevaPelicula() {
            if (Session["UserId"] != null)
            {
                List<Calificacione> Calif = new List<Calificacione>();
                Calif = contexto.Calificaciones.ToList();
                ViewBag.Calif = Calif;

                List<Genero> Gener = new List<Genero>();
                Gener = contexto.Generos.ToList();
                ViewBag.Gener = Gener;

                //ViewData["Calificaciones"] = contexto.Calificaciones.ToList();
                //ViewData["Generos"] = contexto.Generos.ToList();
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "NuevaPelicula";
                return RedirectToAction("Inicio", "Administracion");
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
                Session["CurrentStatus"] = "CrearPelicula";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        [HttpPost]
        public ActionResult CrearPelicula(Pelicula p)
        {
            return RedirectToAction("Peliculas", "Administracion");
        }
        public ActionResult ModificarPelicula()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "ModificarSede";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        [HttpPost]
        public ActionResult ModificarPelicula(int idPelicula, Pelicula pelicula)
        {

            return RedirectToAction("Sedes", "Administracion");
        }

        /*DONE*/public ActionResult Sedes()
        {
            if (Session["UserId"] != null)
            {
                var sedes = contexto.Sedes.ToList();
                ViewBag.Sedes = sedes;
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "Sedes";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        /*DONE*/public ActionResult CrearSede()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "CrearSede";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        /*DONE*/[HttpPost] public ActionResult CrearSede(Sede s)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (contexto)
                {
                    contexto.Sedes.Add(s);
                    contexto.SaveChanges();
                    return RedirectToAction("Sedes", "Administracion");
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", "Error al registrar Sede. " + ex.Message);
                return View();
            }
        }
        /*DONE*/public ActionResult ModificarSede(int idSede)
        {
            if (Session["UserId"] != null)
            {
                Sede s = contexto.Sedes.Where(a => a.IdSede.Equals(idSede)).FirstOrDefault();
                ViewBag.IDSede = Convert.ToInt32(s.IdSede);
                return View(s);
            }
            else
            {
                Session["CurrentStatus"] = "ModificarSede";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        /*DONE*/[HttpPost]public ActionResult ModificarSede(Sede Sede)
        {
            var original = contexto.Sedes.Find(Sede.IdSede);
            original.Nombre = Sede.Nombre;
            original.PrecioGeneral = Sede.PrecioGeneral;
            original.Direccion = Sede.Direccion;
            contexto.SaveChanges();
            return RedirectToAction("Sedes", "Administracion");
        }
               

        public ActionResult Reportes()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "Reportes";
                return RedirectToAction("Inicio", "Administracion");
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
                Session["CurrentStatus"] = "Carteleras";
                return RedirectToAction("Inicio", "Administracion");
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
                Session["CurrentStatus"] = "CrearCartelera";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        [HttpPost]
        public ActionResult CrearCartelera(Cartelera newCartelera)
        {
            contexto.Carteleras.Add(newCartelera);
            contexto.SaveChanges();
            return RedirectToAction("Carteleras", "Administracion");
        }
        public ActionResult ModificarCartelera()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "ModificarCartelera";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        [HttpPost]
        public ActionResult ModificarCartelera(int idCartelera, Cartelera Cartelera)
        {
            return RedirectToAction("Carteleras", "Administracion");
        }
        public ActionResult EliminarCartelera()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                Session["CurrentStatus"] = "EliminarCartelera";
                return RedirectToAction("Inicio", "Administracion");
            }
        }
        [HttpPost]
        public ActionResult EliminarCartelera(int idCartelera)
        {
            return RedirectToAction("Carteleras", "Administracion");
        }

        public ActionResult CerrarSesion()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Inicio", "Administracion");
        }
    }
}