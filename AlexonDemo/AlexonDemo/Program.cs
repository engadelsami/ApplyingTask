
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AlexonDemo.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using AlexonDemo.Repository;
using AlexonDemo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<AlexonDemoDBDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AlexonDemoDB")));

builder.Services.AddControllers();
builder.Services.AddScoped<IComplain,ComplainRepository>();
//------------------------------------------------------------------
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});




//-----------------------------------------------------------------------


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
