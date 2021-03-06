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

        [Display(Name = "Materia")]
        public int MateriaId { get; set; }

        [Display(Name = "Materia")]
        public Materia materia { get; set; }

        [Display(Name = "Alumno")]
        public int AlumnoId { get; set; }

        [Display(Name = "Alumno")]
        public Alumno alumno { get; set; }

    }
}