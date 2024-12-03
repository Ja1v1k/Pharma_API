using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pharma.Data;
using Pharma.Repository;
using Pharma.Repository.Interfaces;
using Pharma.Services;
using Pharma.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PharmaDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection")));

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IPatientService, PatientService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
