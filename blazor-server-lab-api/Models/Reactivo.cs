namespace blazor_server_lab_api.Models
{
    public class Reactivo
    {
        public int IdReactivo { get; set; }
        public string NombreReactivo { get; set; }
        public string Fabricante { get; set; }
        public string Unidad { get; set; }
        public bool Anulado { get; set; }
        public decimal CantidadDisponible { get; set; }
    }
}
