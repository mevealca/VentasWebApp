
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Extentions;
namespace Ventas.Infraestructure.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        private readonly VentasContext _context;
        public CategoriaRepository(VentasContext context) : base(context)
        {
            this._context = context;
        }

        public List<CategoriaModel> GetCategorias()
        {
           var categorias = (from c in _context.Categorias
                            where c.EsActivo  && !c.Eliminado 
                            select c ).ToList().ConvertCategoriaEntityToCategoriaModel();

            return categorias;
       
        }
    }
}
