namespace blazor_server_lab_api.Models
{
    public class Convenio
    {
        public int IdConvenio { get; set; }
        public int IdMedico { get; set; }
        public DateTime FechaConvenio { get; set; }
        public decimal PorcentajeComision { get; set; }
        public decimal MontoTotal { get; set; }
        public bool Anulado { get; set; }
        public int? IdUsuario { get; set; }

        // Propiedades de navegación
        public ICollection<DetalleConvenio> DetallesConvenio { get; set; }  // Relación con la entidad DetalleConvenio

        // Relaciones
        public Medico Medico { get; set; }
        public Usuario Usuario { get; set; }
    }
}
