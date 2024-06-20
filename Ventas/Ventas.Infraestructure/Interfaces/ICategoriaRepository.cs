using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Categorias;

namespace Ventas.Infraestructure.Interfaces
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        List<CategoriaModel> GetCategorias();
        CategoriaModel GetCategoria(int categoriaId);
        void AddCategoria(CategoriaSaveModel categoria);
        void UpdateCategoria(CategoriaUpdateModel categoria);
        void RemoveCategoria(CategoriaRemoveModel categoria);
    }
}
