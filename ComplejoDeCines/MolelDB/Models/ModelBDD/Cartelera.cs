using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplejoDeCines.Models
{
    public class Cartelera
    {
        public int IdCartelera { get; set; }
        public int IdSede { get; set; }
        public int IdPelicula { get; set; }
        public int HoraInicio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int NumeroSala { get; set; }
        public int IdVersion { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public DateTime FechaCarga { get; set; }
    }
}