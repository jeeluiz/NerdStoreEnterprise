using NSe.Catalogo.API;
using NSe.Catalogo.API.Configuration;
using NSe.Catalogo.API.Data;
using NSe.Catalogo.API.Models;
using NSE.Catalogo.API.Configuration;
using NSE.Catalogo.API.Data.Repository;
using NSE.WebApi.Core.Identidade;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddApiConfiguration(builder.Configuration);
builder.Services.AddJwtConfiguration(builder.Configuration);
builder.Services.RegisterServices();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
//builder.Services.AddScoped<CatalogoContext>();
builder.Services.AddSwaggerConfiguration();


var app = builder.Build();



// Configure the HTTP request pipeline.
app.UseSwaggerConfiguration();
app.UseApiConfuguration(builder.Environment);

app.Run();
