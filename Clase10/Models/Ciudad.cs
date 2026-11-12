using System.ComponentModel.DataAnnotations;
namespace Clase10.Models;

public class Ciudad
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Nombre { get; set; }

    public int PaisId { get; set; }

    public Pais? Pais { get; set; }
}