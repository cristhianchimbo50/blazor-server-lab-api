namespace blazor_server_lab_api.Models
{
    public class DetalleConvenio
    {
        public int IdDetalleConvenio { get; set; }  // Clave primaria

        public int IdConvenio { get; set; }  // Clave foránea con la tabla Convenio
        public decimal Subtotal { get; set; }

        // Relación con la tabla Convenio
        public Convenio Convenio { get; set; }
    }
}
