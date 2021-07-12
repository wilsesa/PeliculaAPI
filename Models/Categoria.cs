using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculaAPI.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo estado es obligatorio")]
        public string Estado { get; set; }
    }
}
