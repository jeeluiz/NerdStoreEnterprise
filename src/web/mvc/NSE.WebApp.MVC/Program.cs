using NSE.WebApp.MVC.Configuration;
using NSE.WebApp.MVC.Extensions;
using Topshelf.Runtime;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration
//    .SetBasePath(builder.Environment.ContentRootPath)
//    .AddJsonFile("appsettings.json", true, true)
//    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
//    .AddEnvironmentVariables();

//if (builder.Environment.IsDevelopment())
//{
//    builder.Configuration.AddUserSecrets<Program>();
//}

builder.Services.AddMvcConfiguration(builder.Configuration);

builder.Services.AddIdentityConfiguration();
builder.Services.RegistroService(builder.Configuration); 



var app = builder.Build();
app.UseMvcConfiguration(builder.Environment);
app.UseIdentityConfiguration();

app.Run();
