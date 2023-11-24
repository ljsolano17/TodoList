using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    public class Tareas
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
