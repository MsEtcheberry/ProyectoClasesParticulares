using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNT.Models
{
    public class Clase
    {
        //Poner los displays de los atributos
        //https://www.c-sharpcorner.com/blogs/validation-in-asp-net-mvc-using-dataannotations
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClase { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha y hora")]
        [Required(ErrorMessage = "Ingrese la fecha y la hora")]
        public DateTime fechaYHora { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Ingrese el tema")]
        [Display(Name = "Tema")]
        public string tema { get; set; }

        public int idMateria { get; set; }

        public Materia materia { get; set; }
        
        public int idAlumno { get; set; }
        
        public Alumno alumno { get; set; }

    }
}