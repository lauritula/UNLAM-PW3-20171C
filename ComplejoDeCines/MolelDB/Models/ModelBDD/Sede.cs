using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplejoDeCines.Models
{
    public class Sede
    {
        public int IdSede { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public decimal PrecioGeneral { get; set; }

    }
}