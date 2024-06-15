using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Domain.Interfaces;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Repositories
{
    public class ProductosRepository: BaseRepository<Producto>, IProductoRepository
    {
        protected readonly VentasContext _context;

        public ProductosRepository(VentasContext context) : base(context)
        {
            this._context = context;
        }



        
    }
}
