namespace blazor_server_lab_api.Models
{
    public class DetallePago
    {
        public int IdDetallePago { get; set; }
        public int IdPago { get; set; }
        public string TipoPago { get; set; }
        public decimal Monto { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaAnulacion { get; set; }

        // Relaciones
        public Pago Pago { get; set; }
        public Usuario Usuario { get; set; }
    }
}
