using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplejoDeCines.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdSede { get; set; }
        public int IdVersion { get; set; }
        public int IdPelicula { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public string Email { get; set; }
        public string IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int CantidadEntradas { get; set; }
        public DateTime FechaCarga { get; set; }
    }
}