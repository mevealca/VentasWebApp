
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Repositories
{
    public class ProductosRepository: BaseRepository<Producto>, IProductoRepository
    {
        private readonly VentasContext _context;


        public ProductosRepository(VentasContext context) : base(context)
        {
            this._context = context;
        }



        
    }
}
