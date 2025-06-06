﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazor_server_lab_api.Data;

#nullable disable

namespace blazor_server_lab_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("blazor_server_lab_api.Models.Convenio", b =>
                {
                    b.Property<int>("IdConvenio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConvenio"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaConvenio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("MedicoIdMedico")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeComision")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdConvenio");

                    b.HasIndex("MedicoIdMedico");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Convenios");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetalleConvenio", b =>
                {
                    b.Property<int>("IdDetalleConvenio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleConvenio"));

                    b.Property<int>("ConvenioIdConvenio")
                        .HasColumnType("int");

                    b.Property<int>("IdConvenio")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdDetalleConvenio");

                    b.HasIndex("ConvenioIdConvenio");

                    b.ToTable("DetallesConvenio");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetalleOrden", b =>
                {
                    b.Property<int>("IdDetalleOrden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleOrden"));

                    b.Property<int>("ExamenIdExamen")
                        .HasColumnType("int");

                    b.Property<int>("IdExamen")
                        .HasColumnType("int");

                    b.Property<int>("IdOrden")
                        .HasColumnType("int");

                    b.Property<int>("IdResultado")
                        .HasColumnType("int");

                    b.Property<int>("OrdenIdOrden")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ResultadoIdResultado")
                        .HasColumnType("int");

                    b.HasKey("IdDetalleOrden");

                    b.HasIndex("ExamenIdExamen");

                    b.HasIndex("OrdenIdOrden");

                    b.HasIndex("ResultadoIdResultado");

                    b.ToTable("DetallesOrden");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetallePago", b =>
                {
                    b.Property<int>("IdDetallePago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetallePago"));

                    b.Property<DateTime?>("FechaAnulacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PagoIdPago")
                        .HasColumnType("int");

                    b.Property<string>("TipoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdDetallePago");

                    b.HasIndex("PagoIdPago");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("DetallesPago");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetalleResultado", b =>
                {
                    b.Property<int>("IdDetalleResultado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleResultado"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<int>("ExamenIdExamen")
                        .HasColumnType("int");

                    b.Property<int>("IdExamen")
                        .HasColumnType("int");

                    b.Property<int>("IdResultado")
                        .HasColumnType("int");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResultadoIdResultado")
                        .HasColumnType("int");

                    b.Property<string>("Unidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdDetalleResultado");

                    b.HasIndex("ExamenIdExamen");

                    b.HasIndex("ResultadoIdResultado");

                    b.ToTable("DetallesResultado");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Examen", b =>
                {
                    b.Property<int>("IdExamen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExamen"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombreExamen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Unidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorReferencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdExamen");

                    b.ToTable("Examenes");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.ExamenReactivo", b =>
                {
                    b.Property<int>("IdExamenReactivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExamenReactivo"));

                    b.Property<decimal>("CantidadUsada")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ExamenIdExamen")
                        .HasColumnType("int");

                    b.Property<int>("IdExamen")
                        .HasColumnType("int");

                    b.Property<int>("IdReactivo")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("ReactivoIdReactivo")
                        .HasColumnType("int");

                    b.Property<string>("Unidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdExamenReactivo");

                    b.HasIndex("ExamenIdExamen");

                    b.HasIndex("ReactivoIdReactivo");

                    b.ToTable("ExamenReactivos");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Medico", b =>
                {
                    b.Property<int>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedico"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombreMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdMedico");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.MovimientoReactivo", b =>
                {
                    b.Property<int>("IdMovimientoReactivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMovimientoReactivo"));

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ExamenIdExamen")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaMovimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdExamen")
                        .HasColumnType("int");

                    b.Property<int>("IdOrden")
                        .HasColumnType("int");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdenIdOrden")
                        .HasColumnType("int");

                    b.HasKey("IdMovimientoReactivo");

                    b.HasIndex("ExamenIdExamen");

                    b.HasIndex("OrdenIdOrden");

                    b.ToTable("MovimientoReactivos");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Orden", b =>
                {
                    b.Property<int>("IdOrden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOrden"));

                    b.Property<int?>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("MedicoIdMedico")
                        .HasColumnType("int");

                    b.Property<string>("NumeroOrden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteIdPaciente")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdOrden");

                    b.HasIndex("MedicoIdMedico");

                    b.HasIndex("PacienteIdPaciente");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Paciente", b =>
                {
                    b.Property<int>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPaciente"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<string>("CedulaPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronicoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EdadPaciente")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacPaciente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombrePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdPaciente");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Pago", b =>
                {
                    b.Property<int>("IdPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPago"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdOrden")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoPagado")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdenIdOrden")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdPago");

                    b.HasIndex("OrdenIdOrden");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Reactivo", b =>
                {
                    b.Property<int>("IdReactivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReactivo"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<decimal>("CantidadDisponible")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreReactivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReactivo");

                    b.ToTable("Reactivo");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Resultado", b =>
                {
                    b.Property<int>("IdResultado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdResultado"));

                    b.Property<bool>("Anulado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaResultado")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int?>("IdOrden")
                        .HasColumnType("int");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<int>("MedicoIdMedico")
                        .HasColumnType("int");

                    b.Property<string>("NumeroResultado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdenIdOrden")
                        .HasColumnType("int");

                    b.Property<int>("PacienteIdPaciente")
                        .HasColumnType("int");

                    b.HasKey("IdResultado");

                    b.HasIndex("MedicoIdMedico");

                    b.HasIndex("OrdenIdOrden");

                    b.HasIndex("PacienteIdPaciente");

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("ClaveUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsContraseñaTemporal")
                        .HasColumnType("bit");

                    b.Property<bool>("EstadoRegistro")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Convenio", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Medico", "Medico")
                        .WithMany("Convenios")
                        .HasForeignKey("MedicoIdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetalleConvenio", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Convenio", "Convenio")
                        .WithMany("DetallesConvenio")
                        .HasForeignKey("ConvenioIdConvenio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Convenio");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetalleOrden", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Examen", "Examen")
                        .WithMany()
                        .HasForeignKey("ExamenIdExamen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Orden", "Orden")
                        .WithMany()
                        .HasForeignKey("OrdenIdOrden")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Resultado", "Resultado")
                        .WithMany()
                        .HasForeignKey("ResultadoIdResultado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Examen");

                    b.Navigation("Orden");

                    b.Navigation("Resultado");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetallePago", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Pago", "Pago")
                        .WithMany()
                        .HasForeignKey("PagoIdPago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pago");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.DetalleResultado", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Examen", "Examen")
                        .WithMany("DetallesResultado")
                        .HasForeignKey("ExamenIdExamen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Resultado", "Resultado")
                        .WithMany("DetallesResultado")
                        .HasForeignKey("ResultadoIdResultado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Examen");

                    b.Navigation("Resultado");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.ExamenReactivo", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Examen", "Examen")
                        .WithMany("ExamenesReactivos")
                        .HasForeignKey("ExamenIdExamen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Reactivo", "Reactivo")
                        .WithMany()
                        .HasForeignKey("ReactivoIdReactivo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Examen");

                    b.Navigation("Reactivo");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Medico", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Usuario", "Usuario")
                        .WithMany("Medicos")
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.MovimientoReactivo", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Examen", "Examen")
                        .WithMany("MovimientosReactivos")
                        .HasForeignKey("ExamenIdExamen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Orden", "Orden")
                        .WithMany("MovimientosReactivos")
                        .HasForeignKey("OrdenIdOrden")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Examen");

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Orden", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Medico", "Medico")
                        .WithMany("Ordenes")
                        .HasForeignKey("MedicoIdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Paciente", "Paciente")
                        .WithMany("Ordenes")
                        .HasForeignKey("PacienteIdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Usuario", "Usuario")
                        .WithMany("Ordenes")
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Paciente", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Usuario", "Usuario")
                        .WithMany("Pacientes")
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Pago", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Orden", "Orden")
                        .WithMany("Pagos")
                        .HasForeignKey("OrdenIdOrden")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Usuario", "Usuario")
                        .WithMany("Pagos")
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orden");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Resultado", b =>
                {
                    b.HasOne("blazor_server_lab_api.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoIdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Orden", "Orden")
                        .WithMany()
                        .HasForeignKey("OrdenIdOrden")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_server_lab_api.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteIdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Orden");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Convenio", b =>
                {
                    b.Navigation("DetallesConvenio");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Examen", b =>
                {
                    b.Navigation("DetallesResultado");

                    b.Navigation("ExamenesReactivos");

                    b.Navigation("MovimientosReactivos");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Medico", b =>
                {
                    b.Navigation("Convenios");

                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Orden", b =>
                {
                    b.Navigation("MovimientosReactivos");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Paciente", b =>
                {
                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Resultado", b =>
                {
                    b.Navigation("DetallesResultado");
                });

            modelBuilder.Entity("blazor_server_lab_api.Models.Usuario", b =>
                {
                    b.Navigation("Medicos");

                    b.Navigation("Ordenes");

                    b.Navigation("Pacientes");

                    b.Navigation("Pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
