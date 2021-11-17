using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Docente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDocente { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Ingrese el nombre")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Ingrese el apellido"), MaxLength(30)]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Ingrese el mail")]
        [Display(Name = "Email")]
        public string mail { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Ingrese la descripción"), MaxLength(500)]
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
        
        public ICollection<Materia> materias { get; set; }

    }
}
