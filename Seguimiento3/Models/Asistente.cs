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
    [RegularExpression(@"^\d{7,10}$", ErrorMessage = "El teléfono debe tener entre 7 y 10 dígitos.")]
    public string Telefono { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe seleccionar un tipo de asistente.")]
    public string TipoAsistente { get; set; } = string.Empty;

    [AlMenosUno(ErrorMessage = "Debe seleccionar al menos un taller.")]
    public List<string> Taller { get; set; } = new List<string>();
}

public class AlMenosUnoAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is IEnumerable<string> lista && lista.Any(x => !string.IsNullOrWhiteSpace(x));
    }
}