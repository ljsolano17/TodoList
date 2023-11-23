namespace Solution.API.TodoList.datamodels
{
    public class Tareas
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public DateTime FechaDeCreacion { get; set; }

        public DateTime FechaDeVencimiento { get; set; }

        public bool Completada { get; set; }

        public int? UserId { get; set; }
    }
}
