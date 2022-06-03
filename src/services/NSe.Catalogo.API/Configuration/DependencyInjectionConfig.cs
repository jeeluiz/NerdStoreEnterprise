using NSe.Catalogo.API.Data;
using NSe.Catalogo.API.Data.Repository;
using NSe.Catalogo.API.Models;

namespace NSe.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();

        }
    }
}
