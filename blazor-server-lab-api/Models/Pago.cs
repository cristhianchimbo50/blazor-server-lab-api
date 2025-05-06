namespace blazor_server_lab_api.Models
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int IdOrden { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public string Observacion { get; set; }
        public bool Anulado { get; set; }
        public int? IdUsuario { get; set; }

        // Relaciones
        public Orden Orden { get; set; }
        public Usuario Usuario { get; set; }
    }
}
