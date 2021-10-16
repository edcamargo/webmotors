using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebMotors.InfraStructure.Data.Context;
using WebMotors.InfraStructure.Ioc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("Database"));
/*
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));
});
*/

//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "webApi", Version = "v1" });
});

DependencyInjection.DependencyInjectionServices(builder.Services);
DependencyInjection.DependencyInjectionRepositories(builder.Services);

await using var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "webApi v1"));
}

app.UseAuthorization();

app.MapControllers();

app.Run();
