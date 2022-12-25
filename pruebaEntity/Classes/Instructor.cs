namespace pruebaEntity.Classes
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Grado { get; set; }
        public string? Foto { get; set; }

        public ICollection<cursoInstructor>? CursoInstructors { get; set; }
    }
}
