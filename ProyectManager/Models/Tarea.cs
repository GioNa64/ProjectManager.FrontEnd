namespace ProyectManager.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public int IdColaborador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Prioridad { get; set; }
        public int Esfuerzo { get; set; }
        public int Estado { get; set; }
    }
}
