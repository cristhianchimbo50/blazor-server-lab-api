namespace blazor_server_lab_api.Models
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public string NumeroOrden { get; set; }
        public int IdPaciente { get; set; }
        public int? IdMedico { get; set; }
        public int? IdUsuario { get; set; }

        // Propiedades de navegación
        public ICollection<Pago> Pagos { get; set; }  // Relación con la entidad Pago
        public ICollection<MovimientoReactivo> MovimientosReactivos { get; set; }  // Relación con la entidad MovimientoReactivo

        // Relaciones
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public Usuario Usuario { get; set; }
    }
}
