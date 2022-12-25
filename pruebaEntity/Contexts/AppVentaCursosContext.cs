using Microsoft.EntityFrameworkCore;
using pruebaEntity.Classes;

namespace pruebaEntity.Contexts
{
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=CursosOnline;Integrated Security=True; TrustServerCertificate=True";
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<cursoInstructor> cursoInstructor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //Se le indica que la clase intermedia cusoInstructor tiene dos claves primarias
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cursoInstructor>().HasKey(ci => new { ci.cursoId, ci.InstructorId });
        }


    }
}

