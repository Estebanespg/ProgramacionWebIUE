using System.ComponentModel.DataAnnotations;
namespace Clase10.Models;

public class Pais
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Nombre { get; set; }

    public ICollection<Ciudad> Ciudades { get; set; } = new List<Ciudad>();
}