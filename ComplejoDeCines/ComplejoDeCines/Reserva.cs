//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComplejoDeCines
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public int IdSede { get; set; }
        public int IdVersion { get; set; }
        public int IdPelicula { get; set; }
        public System.DateTime FechaHoraInicio { get; set; }
        public string Email { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int CantidadEntradas { get; set; }
        public System.DateTime FechaCarga { get; set; }
    
        public virtual Pelicula Pelicula { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual TiposDocumento TiposDocumento { get; set; }
        public virtual Versione Versione { get; set; }
    }
}
