using Microsoft.EntityFrameworkCore;
using blazor_server_lab_api.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor

// Registrar ApplicationDbContext con la cadena de conexi�n a SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar controladores de API
builder.Services.AddControllers();

// Configuraci�n de Swagger/OpenAPI para documentaci�n de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar la tuber�a de solicitud HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Usar autorizaci�n para las peticiones
app.UseAuthorization();

// Mapear los controladores de la API
app.MapControllers();

// Ejecutar la aplicaci�n
app.Run();
