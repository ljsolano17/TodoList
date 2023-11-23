using System;
using System.Collections.Generic;

namespace Solution.API.Wizard.Models;

public partial class Tarea
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FechaDeCreacion { get; set; }

    public DateTime FechaDeVencimiento { get; set; }

    public bool Completada { get; set; }

    public int? UserId { get; set; }
}
