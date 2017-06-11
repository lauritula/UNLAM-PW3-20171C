using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplejoDeCines.Models
{
    public class LoginAdministradorModels
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Ingresar Contraseña")]
        public int Password { get; set; }
    }
}