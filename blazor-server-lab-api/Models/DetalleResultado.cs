namespace blazor_server_lab_api.Models
{
    public class DetalleResultado
    {
        public int IdDetalleResultado { get; set; }
        public int IdResultado { get; set; }
        public int IdExamen { get; set; }
        public decimal Valor { get; set; }
        public string Unidad { get; set; }
        public string Observacion { get; set; }
        public bool Anulado { get; set; }

        // Relaciones
        public Resultado Resultado { get; set; }
        public Examen Examen { get; set; }
    }
}
