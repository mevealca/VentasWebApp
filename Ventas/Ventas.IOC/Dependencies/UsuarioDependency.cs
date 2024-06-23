using Microsoft.Extensions.DependencyInjection;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Repositories;

namespace Ventas.IOC.Dependencies
{
    public static class UsuarioDependency 
    {
        public static void AddUsuarioDependency(this IServiceCollection services) {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
