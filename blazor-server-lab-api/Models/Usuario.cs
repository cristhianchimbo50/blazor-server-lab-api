namespace blazor_server_lab_api.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public bool EsContraseñaTemporal { get; set; }
        public bool EstadoRegistro { get; set; }

        // Relaciones
        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
        public ICollection<Pago> Pagos { get; set; }
    }
}
