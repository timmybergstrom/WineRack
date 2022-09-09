using Microsoft.EntityFrameworkCore;
using WineRack.Application;
using WineRack.Domain;
using WineRack.Repository;
//using SeriLog;

//Log.Logger = new LoggerConfiguration()
  //  .MinimumLevel.Debug()
    //.WriteTo.Console()
    //.WriteTo.File("logs/wineracklogs.txt", rollingInterval: RollingInterval.Day)
    //.CreateLogger();

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

//builder.Host.UseSeriLog();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices(configuration);
builder.Services.AddRepositoryServices(configuration);
builder.Services.AddDomainServices(configuration);

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
