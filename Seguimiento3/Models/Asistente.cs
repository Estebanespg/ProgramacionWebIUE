using System.ComponentModel.DataAnnotations;
namespace Seguimiento3.Models;

public class Asistente
{
    [Required(ErrorMessage = "El nombre completo es obligatorio.")]
    public string NombreCompleto { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
    public string CorreoElectronico { get; set; } = string.Empty;

    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    public string Telefono { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe seleccionar un tipo de asistente.")]
    public string TipoAsistente { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe seleccionar al menos un taller.")]
    public List<string> Taller { get; set; } = new List<string>();
}