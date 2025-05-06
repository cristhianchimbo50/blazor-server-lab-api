namespace blazor_server_lab_api.Models
{
    public class Medico
    {
        public int IdMedico { get; set; }
        public string NombreMedico { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool Anulado { get; set; }
        public int? IdUsuario { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }
        public ICollection<Convenio> Convenios { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}
