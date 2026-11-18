using System;
using System.Collections.Generic;

namespace Clase11.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public bool Activo { get; set; }
}
