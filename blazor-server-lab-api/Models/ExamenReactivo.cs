namespace blazor_server_lab_api.Models
{
    public class ExamenReactivo
    {
        public int IdExamenReactivo { get; set; }
        public int IdExamen { get; set; }
        public int IdReactivo { get; set; }
        public decimal CantidadUsada { get; set; }
        public string Unidad { get; set; }
        public int? IdUsuario { get; set; }

        // Propiedades de navegación
        public Examen Examen { get; set; }
        public Reactivo Reactivo { get; set; }
    }
}
