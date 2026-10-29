using System.ComponentModel.DataAnnotations;

namespace Clase09.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Los nombres son obligatorios.")]
        [StringLength(80)]
        [Display(Name = "Nombres")]

        public string Nombres { get; set; } = string.Empty;
        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        [StringLength(80)]
        [Display(Name = "Apellidos")]

        public string Apellidos { get; set; } = string.Empty;
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]

        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "¿Está casado?")]

        public bool Casado { get; set; }
        [Range(0, 30, ErrorMessage = "Ingresa un valor entre 0 y 30.")]
        [Display(Name = "Número de hermanos")]
        
        public int NumeroHermanos { get; set; }
    }
}