using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplejoDeCines.Models
{
    public class LoginAdministradorModels
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Ingresar Contraseña")]
        public string Password { get; set; }
    }

    //SEDES

    public class CrearSedeModels
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string PrecioGeneral { get; set; }
    }

    //PELICULAS

    public class CrearPeliculaModels
    {
        //[Required(ErrorMessage = "Campo Obligatorio")]
        public string Nombre { get; set; }

        //[Required(ErrorMessage = "Campo Obligatorio")]
        public string Descripcion { get; set; }

        //[Required(ErrorMessage = "Campo Obligatorio")]
        public string IdCalificacion { get; set; }

        //[Required(ErrorMessage = "Campo Obligatorio")]
        public string IdGenero { get; set; }

        //[Required(ErrorMessage = "Campo Obligatorio")]
        public string Imagen { get; set; }

        //[Required(ErrorMessage = "Campo Obligatorio")]
        public string Duracion { get; set; }

        public string FechaCarga { get; set; }
    }

    //CARTELERAS

    //REPORTES
}