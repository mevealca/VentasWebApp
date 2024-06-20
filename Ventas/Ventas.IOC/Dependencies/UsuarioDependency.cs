using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
