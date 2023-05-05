using Api.Airbnb.DBContext;
using Api.Airbnb.Repository;
using Api.Airbnb.Repository.Imp;
using Api.Airbnb.Services;
using Api.Airbnb.Services.Imp;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Xml.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ChozadbContext>(options =>
options.UseMySQL(builder.Configuration.GetConnectionString("conection"))
);

builder.Services.AddTransient<IHousingRepository, ImpHousingRepository>();
builder.Services.AddTransient<IHousing, ImpHousing>();
builder.Services.AddTransient<IOwnerRepository, ImpOwnerRepository>();


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
