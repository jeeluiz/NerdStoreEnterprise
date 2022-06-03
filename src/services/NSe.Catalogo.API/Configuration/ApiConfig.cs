using Microsoft.EntityFrameworkCore;
using NSe.Catalogo.API.Data;
using NSE.WebApi.Core.Identidade;

namespace NSe.Catalogo.API.Configuration
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CatalogoContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));


            });

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy(name: "Total",
                    configurePolicy: builder =>
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }
        public static void UseApiConfuguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("Total");
            app.UseAuthConfiguration();
            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());
        } 
    }
}
