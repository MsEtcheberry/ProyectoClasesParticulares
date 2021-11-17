using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idMateria { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Ingrese el nombre")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
    }
}