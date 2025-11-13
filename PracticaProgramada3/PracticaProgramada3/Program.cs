using Microsoft.EntityFrameworkCore;
using PracticaProgramada3.BLL.Mapeos;
using PracticaProgramada3.BLL.Servicios;
using PracticaProgramada3.DLL;
using PracticaProgramada3.DLL.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//**//Base de datos
builder.Services.AddDbContext<ApiContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Inyección de dependencias
builder.Services.AddScoped<IVehiculosRepositorio, VehiculosRepositorio>();
builder.Services.AddScoped<IVehiculosServicio, VehiculoServicio>();


builder.Services.AddAutoMapper(cfg => { }, typeof(MapeoClases));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
