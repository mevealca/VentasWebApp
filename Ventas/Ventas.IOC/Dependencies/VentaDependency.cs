using Microsoft.Extensions.DependencyInjection;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Repositories;


namespace Ventas.IOC.Dependencies
{
    public static class VentaDependency
    {
        public static void AddVentaDependency(this IServiceCollection services)
        {
            services.AddScoped<IVentaRepository, VentaRepository>();

        }
    }
}
