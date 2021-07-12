using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculaAPI.Models
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo nombre es obligatório")]
        public string NombrePelicula { get; set; }

        [Required(ErrorMessage ="El campo categoria Id es obligatório")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        public string Director { get; set; }
    }
}
