using Microsoft.EntityFrameworkCore;
using pruebaEntity.Contexts;

namespace pruebaEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaCursosContext())
            {               
                var cursos = db.Curso.Include(c => c.CursoInstructors).ThenInclude(ci => ci.Instructor);
          
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.titulo);

                    foreach (var cursoInstructores in curso.CursoInstructors)
                    {
                        Console.WriteLine(cursoInstructores.Instructor.Nombre + " " + cursoInstructores.Instructor.Apellidos);
                    }
                }
            }
        }
    }
}

