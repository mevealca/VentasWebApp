using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Repositories;

namespace Ventas.IOC.Dependencies
{
    public static class CategoriaDependency
    {
        public static void AddCategoriaDependency(this IServiceCollection services)
        {

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        }
    }
}
