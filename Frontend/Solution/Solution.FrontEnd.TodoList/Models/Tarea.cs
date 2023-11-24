using System;
using System.Collections.Generic;

namespace Solution.FrontEnd.TodoList.Models
{
    public partial class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public bool Completada { get; set; }
        public string UserId { get; set; }
    }
}
