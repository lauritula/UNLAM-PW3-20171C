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
}