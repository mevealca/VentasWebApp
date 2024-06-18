using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Interfaces
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        List<CategoriaModel> GetCategorias();
       }
}
