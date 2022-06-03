using NSe.Catalogo.API.Configuration;
using NSe.Catalogo.API.Data;
using NSe.Catalogo.API.Data.Repository;
using NSe.Catalogo.API.Models;
using NSE.Catalogo.API.Configuration;
using NSE.WebApi.Core.Identidade;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiConfiguration(builder.Configuration);
builder.Services.RegisterServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProdutoRepository,ProdutoRepository>();
builder.Services.AddScoped<CatalogoContext>();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddJwtConfiguration(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseApiConfuguration(builder.Environment);
app.UseSwaggerConfiguration();

app.Run();
