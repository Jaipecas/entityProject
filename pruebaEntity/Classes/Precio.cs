namespace pruebaEntity.Classes
{
    public class Precio
    {
        public int precioId { get; set; }
        public decimal precioActual { get; set; }
        public decimal promocion { get; set; }
        public int cursoId { get; set; }
        public Curso? curso { get; set; }                
    }
}
