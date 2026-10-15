using System.ComponentModel.DataAnnotations;

namespace HolaMVC.Models;

public class Persona
{
    [Required(ErrorMessage = "El nombre no puede estar vacio")]
    [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
    public string Nombre { get; set; } = string.Empty;
}