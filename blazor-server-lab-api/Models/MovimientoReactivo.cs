namespace blazor_server_lab_api.Models
{
    public class MovimientoReactivo
    {
        public int IdMovimientoReactivo { get; set; }
        public int IdExamen { get; set; }
        public int IdOrden { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string Observacion { get; set; }

        // Propiedades de navegación
        public Examen Examen { get; set; }  // Relación con la entidad Examen
        public Orden Orden { get; set; }  // Relación con la entidad Orden
    }
}
