namespace pruebaEntity.Classes
{
    public class Comentario
    {
        public int? ComentarioId { get; set; }
        public string? Alumno { get; set; }
        public int? Puntaje { get; set; }
        public string? ComentarioTexto { get; set; }
        public Curso? Curso { get; set; }
    }
}
