using Microsoft.EntityFrameworkCore;
using System;

using Ventas.Domain.Entities;

namespace Ventas.Infraestructure.Context
{
    public class VentasContext :DbContext
    {
        public VentasContext (DbContextOptions<VentasContext>dbContext) :base(dbContext) {
        
        }

        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<RolMenu> RolMenus { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }


    }
}
