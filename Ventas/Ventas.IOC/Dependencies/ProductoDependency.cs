

using Microsoft.Extensions.DependencyInjection;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Repositories;

namespace Ventas.IOC.Dependencies
{
    public static class ProductoDependency
    {
        public static void AddProductoDependency(this IServiceCollection services)
        {

            services.AddScoped<IProductoRepository, ProductosRepository>();
        }
    }
}
