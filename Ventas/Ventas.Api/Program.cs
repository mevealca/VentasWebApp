using Microsoft.EntityFrameworkCore;
using Ventas.Infraestructure.Context;
using Ventas.IOC.Dependencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VentasContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VentasContext")));

// my Services

builder.Services.AddProductoDependency();
builder.Services.AddCategoriaDependency();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
