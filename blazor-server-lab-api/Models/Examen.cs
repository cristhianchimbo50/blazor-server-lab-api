namespace blazor_server_lab_api.Models
{
    public class Examen
    {
        public int IdExamen { get; set; }
        public string NombreExamen { get; set; }
        public string ValorReferencia { get; set; }
        public string Unidad { get; set; }
        public decimal Precio { get; set; }
        public bool Anulado { get; set; }
        public int? IdUsuario { get; set; }

        // Propiedad de navegación: Examen puede tener muchos ExamenesReactivos
        public ICollection<ExamenReactivo> ExamenesReactivos { get; set; }
        public ICollection<MovimientoReactivo> MovimientosReactivos { get; set; }
        public ICollection<DetalleResultado> DetallesResultado { get; set; }


    }
}
