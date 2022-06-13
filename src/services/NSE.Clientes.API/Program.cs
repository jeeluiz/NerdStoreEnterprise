using MediatR;
using Microsoft.EntityFrameworkCore;
using NSE.Clientes.API.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ClientesContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Total",
        configurePolicy: builder =>
        builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors("Total");
app.UseAuthorization();

app.MapControllers();

app.Run();
