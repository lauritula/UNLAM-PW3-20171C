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
        CineDB contexto;
        public PeliculasController()
        {
            contexto = new CineDB();

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reserva()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearReserva(Reserva nuevaReserva)
        {

            //contexto.Reservas.Add(nuevaReserva);
            //contexto.SaveChanges();
            return RedirectToAction("Peliculas", "Confirmacion");
        }
        public ActionResult Confirmacion()
        {
            return View();
        }
    }
}