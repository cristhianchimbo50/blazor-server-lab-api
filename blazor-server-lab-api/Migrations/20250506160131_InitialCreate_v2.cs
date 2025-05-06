using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor_server_lab_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examenes",
                columns: table => new
                {
                    IdExamen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreExamen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorReferencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examenes", x => x.IdExamen);
                });

            migrationBuilder.CreateTable(
                name: "Reactivo",
                columns: table => new
                {
                    IdReactivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreReactivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    CantidadDisponible = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactivo", x => x.IdReactivo);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorreoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaveUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsContraseñaTemporal = table.Column<bool>(type: "bit", nullable: false),
                    EstadoRegistro = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "ExamenReactivos",
                columns: table => new
                {
                    IdExamenReactivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdExamen = table.Column<int>(type: "int", nullable: false),
                    IdReactivo = table.Column<int>(type: "int", nullable: false),
                    CantidadUsada = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    ExamenIdExamen = table.Column<int>(type: "int", nullable: false),
                    ReactivoIdReactivo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamenReactivos", x => x.IdExamenReactivo);
                    table.ForeignKey(
                        name: "FK_ExamenReactivos_Examenes_ExamenIdExamen",
                        column: x => x.ExamenIdExamen,
                        principalTable: "Examenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamenReactivos_Reactivo_ReactivoIdReactivo",
                        column: x => x.ReactivoIdReactivo,
                        principalTable: "Reactivo",
                        principalColumn: "IdReactivo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    IdMedico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.IdMedico);
                    table.ForeignKey(
                        name: "FK_Medicos_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CedulaPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombrePaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacPaciente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EdadPaciente = table.Column<int>(type: "int", nullable: false),
                    DireccionPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronicoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.IdPaciente);
                    table.ForeignKey(
                        name: "FK_Pacientes_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Convenios",
                columns: table => new
                {
                    IdConvenio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    FechaConvenio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PorcentajeComision = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    MedicoIdMedico = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenios", x => x.IdConvenio);
                    table.ForeignKey(
                        name: "FK_Convenios_Medicos_MedicoIdMedico",
                        column: x => x.MedicoIdMedico,
                        principalTable: "Medicos",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Convenios_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    IdOrden = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroOrden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    PacienteIdPaciente = table.Column<int>(type: "int", nullable: false),
                    MedicoIdMedico = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.IdOrden);
                    table.ForeignKey(
                        name: "FK_Ordenes_Medicos_MedicoIdMedico",
                        column: x => x.MedicoIdMedico,
                        principalTable: "Medicos",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordenes_Pacientes_PacienteIdPaciente",
                        column: x => x.PacienteIdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordenes_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesConvenio",
                columns: table => new
                {
                    IdDetalleConvenio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConvenio = table.Column<int>(type: "int", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ConvenioIdConvenio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesConvenio", x => x.IdDetalleConvenio);
                    table.ForeignKey(
                        name: "FK_DetallesConvenio_Convenios_ConvenioIdConvenio",
                        column: x => x.ConvenioIdConvenio,
                        principalTable: "Convenios",
                        principalColumn: "IdConvenio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimientoReactivos",
                columns: table => new
                {
                    IdMovimientoReactivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdExamen = table.Column<int>(type: "int", nullable: false),
                    IdOrden = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FechaMovimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamenIdExamen = table.Column<int>(type: "int", nullable: false),
                    OrdenIdOrden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoReactivos", x => x.IdMovimientoReactivo);
                    table.ForeignKey(
                        name: "FK_MovimientoReactivos_Examenes_ExamenIdExamen",
                        column: x => x.ExamenIdExamen,
                        principalTable: "Examenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovimientoReactivos_Ordenes_OrdenIdOrden",
                        column: x => x.OrdenIdOrden,
                        principalTable: "Ordenes",
                        principalColumn: "IdOrden",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrden = table.Column<int>(type: "int", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoPagado = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    OrdenIdOrden = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pagos_Ordenes_OrdenIdOrden",
                        column: x => x.OrdenIdOrden,
                        principalTable: "Ordenes",
                        principalColumn: "IdOrden",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    IdResultado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroResultado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    FechaResultado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdOrden = table.Column<int>(type: "int", nullable: true),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    PacienteIdPaciente = table.Column<int>(type: "int", nullable: false),
                    MedicoIdMedico = table.Column<int>(type: "int", nullable: false),
                    OrdenIdOrden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => x.IdResultado);
                    table.ForeignKey(
                        name: "FK_Resultados_Medicos_MedicoIdMedico",
                        column: x => x.MedicoIdMedico,
                        principalTable: "Medicos",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resultados_Ordenes_OrdenIdOrden",
                        column: x => x.OrdenIdOrden,
                        principalTable: "Ordenes",
                        principalColumn: "IdOrden",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resultados_Pacientes_PacienteIdPaciente",
                        column: x => x.PacienteIdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesPago",
                columns: table => new
                {
                    IdDetallePago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPago = table.Column<int>(type: "int", nullable: false),
                    TipoPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    FechaAnulacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PagoIdPago = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPago", x => x.IdDetallePago);
                    table.ForeignKey(
                        name: "FK_DetallesPago_Pagos_PagoIdPago",
                        column: x => x.PagoIdPago,
                        principalTable: "Pagos",
                        principalColumn: "IdPago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesPago_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesOrden",
                columns: table => new
                {
                    IdDetalleOrden = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrden = table.Column<int>(type: "int", nullable: false),
                    IdExamen = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdResultado = table.Column<int>(type: "int", nullable: false),
                    OrdenIdOrden = table.Column<int>(type: "int", nullable: false),
                    ExamenIdExamen = table.Column<int>(type: "int", nullable: false),
                    ResultadoIdResultado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesOrden", x => x.IdDetalleOrden);
                    table.ForeignKey(
                        name: "FK_DetallesOrden_Examenes_ExamenIdExamen",
                        column: x => x.ExamenIdExamen,
                        principalTable: "Examenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesOrden_Ordenes_OrdenIdOrden",
                        column: x => x.OrdenIdOrden,
                        principalTable: "Ordenes",
                        principalColumn: "IdOrden",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesOrden_Resultados_ResultadoIdResultado",
                        column: x => x.ResultadoIdResultado,
                        principalTable: "Resultados",
                        principalColumn: "IdResultado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesResultado",
                columns: table => new
                {
                    IdDetalleResultado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdResultado = table.Column<int>(type: "int", nullable: false),
                    IdExamen = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    ResultadoIdResultado = table.Column<int>(type: "int", nullable: false),
                    ExamenIdExamen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesResultado", x => x.IdDetalleResultado);
                    table.ForeignKey(
                        name: "FK_DetallesResultado_Examenes_ExamenIdExamen",
                        column: x => x.ExamenIdExamen,
                        principalTable: "Examenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesResultado_Resultados_ResultadoIdResultado",
                        column: x => x.ResultadoIdResultado,
                        principalTable: "Resultados",
                        principalColumn: "IdResultado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Convenios_MedicoIdMedico",
                table: "Convenios",
                column: "MedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Convenios_UsuarioIdUsuario",
                table: "Convenios",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesConvenio_ConvenioIdConvenio",
                table: "DetallesConvenio",
                column: "ConvenioIdConvenio");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOrden_ExamenIdExamen",
                table: "DetallesOrden",
                column: "ExamenIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOrden_OrdenIdOrden",
                table: "DetallesOrden",
                column: "OrdenIdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOrden_ResultadoIdResultado",
                table: "DetallesOrden",
                column: "ResultadoIdResultado");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPago_PagoIdPago",
                table: "DetallesPago",
                column: "PagoIdPago");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPago_UsuarioIdUsuario",
                table: "DetallesPago",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesResultado_ExamenIdExamen",
                table: "DetallesResultado",
                column: "ExamenIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesResultado_ResultadoIdResultado",
                table: "DetallesResultado",
                column: "ResultadoIdResultado");

            migrationBuilder.CreateIndex(
                name: "IX_ExamenReactivos_ExamenIdExamen",
                table: "ExamenReactivos",
                column: "ExamenIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_ExamenReactivos_ReactivoIdReactivo",
                table: "ExamenReactivos",
                column: "ReactivoIdReactivo");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_UsuarioIdUsuario",
                table: "Medicos",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoReactivos_ExamenIdExamen",
                table: "MovimientoReactivos",
                column: "ExamenIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoReactivos_OrdenIdOrden",
                table: "MovimientoReactivos",
                column: "OrdenIdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_MedicoIdMedico",
                table: "Ordenes",
                column: "MedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_PacienteIdPaciente",
                table: "Ordenes",
                column: "PacienteIdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_UsuarioIdUsuario",
                table: "Ordenes",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_UsuarioIdUsuario",
                table: "Pacientes",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_OrdenIdOrden",
                table: "Pagos",
                column: "OrdenIdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_UsuarioIdUsuario",
                table: "Pagos",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_MedicoIdMedico",
                table: "Resultados",
                column: "MedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_OrdenIdOrden",
                table: "Resultados",
                column: "OrdenIdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_PacienteIdPaciente",
                table: "Resultados",
                column: "PacienteIdPaciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesConvenio");

            migrationBuilder.DropTable(
                name: "DetallesOrden");

            migrationBuilder.DropTable(
                name: "DetallesPago");

            migrationBuilder.DropTable(
                name: "DetallesResultado");

            migrationBuilder.DropTable(
                name: "ExamenReactivos");

            migrationBuilder.DropTable(
                name: "MovimientoReactivos");

            migrationBuilder.DropTable(
                name: "Convenios");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Reactivo");

            migrationBuilder.DropTable(
                name: "Examenes");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
