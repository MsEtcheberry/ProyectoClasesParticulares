using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Alumno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAlumno { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Ingrese el nombre"), MaxLength(30)]
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
        [Display(Name = "Escuela")]
        public string escuela { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Ingrese la fecha de nacimiento")]
        public DateTime fechaNacimiento { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Grado")]
        public string grado { get; set; }

        public string nombreCompleto
        {
            get
            {
                return nombre + " " + apellido;
            }
        }
    }

}