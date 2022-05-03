using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Clase_Layouts_PV_Valid.Validaciones;

namespace Clase_Layouts_PV_Valid.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [MinLength(7, ErrorMessage = "AvatarURL debe tener al menos 7 caracteres ")]
        [Required(ErrorMessage = "AvatarURL requerido")]
        [Url(ErrorMessage = "AvatarURL debe ser una URL válida")]
        public string AvatarURL { get; set; }
        [ExcluirDominios("gmail.com,yahoo.com")]
        public string Email { get; set; }
        [Range(1,100000, ErrorMessage = "Puntos debe ser un valor entre 1 y 100000")]
        [Required(ErrorMessage = "Puntos es requerido")]
        public int Puntos { get; set; }

    }
}
