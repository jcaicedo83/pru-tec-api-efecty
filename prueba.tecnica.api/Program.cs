using prueba.tecnica.application;
using prueba.tecnica.core.interfaces.repository;
using prueba.tecnica.core.interfaces.services;
using prueba.tecnica.infraestructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IClientesRepository, ClientesRepository>();
builder.Services.AddTransient<IClientesService, ClientesService>();
builder.Services.AddTransient<IEstadoCivilRepository, EstadoCivilRepository>();
builder.Services.AddTransient<IEstadoCivilService, EstadoCivilService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();
