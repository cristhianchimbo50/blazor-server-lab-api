namespace blazor_server_lab_api.Models
{
    public class DetalleOrden
    {
        public int IdDetalleOrden { get; set; }
        public int IdOrden { get; set; }
        public int IdExamen { get; set; }
        public decimal Precio { get; set; }
        public int IdResultado { get; set; }

        // Relaciones
        public Orden Orden { get; set; }
        public Examen Examen { get; set; }
        public Resultado Resultado { get; set; }
    }
}
