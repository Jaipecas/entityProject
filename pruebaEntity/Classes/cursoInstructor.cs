namespace pruebaEntity.Classes
{
    public class cursoInstructor
    {
        public int cursoId { get; set; }
        public Curso? Curso { get; set; }
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

    }
}
