using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prome.Models
{
    public class RegistroAlumnos
    {
        //Seter y getter para lista 
        //Validando

        [Required(ErrorMessage = "El ID es necesario")]
        public string id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre de usuario debe tener al menos 3 caracteres")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripcion valida")]
        public string descripcion { get; set; }

        [Range(1, 10000, ErrorMessage = "Ingrese un precio mayor a 0")]
        public int precio { get; set; }

    }
}