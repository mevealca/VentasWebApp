using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Domain.Interfaces
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        List<CategoriaModel> GetCategorias();
       }
}
