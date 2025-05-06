namespace blazor_server_lab_api.Models
{
    public class Resultado
    {
        public int IdResultado { get; set; }
        public string NumeroResultado { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public DateTime FechaResultado { get; set; }
        public string Observaciones { get; set; }
        public int? IdOrden { get; set; }
        public bool Anulado { get; set; }

        // Relaciones
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public Orden Orden { get; set; }

        public ICollection<DetalleResultado> DetallesResultado { get; set; }


    }
}
