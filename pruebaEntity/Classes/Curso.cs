namespace pruebaEntity.Classes
{
    public class Curso
    {
        public int cursoId { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public Precio? precio { get; set; }
        public ICollection<Comentario>? Comentarios { get; set; }

        public ICollection<cursoInstructor>? CursoInstructors { get; set; }

    }
}
