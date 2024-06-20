using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Categorias;
using Ventas.Infraestructure.Models.Productos;

namespace Ventas.Infraestructure.Interfaces
{
    public interface IProductoRepository : IBaseRepository<Producto>
    {
        List<ProductoModel> GetProductos();
        ProductoModel GetProducto(int categoriaId);
        void AddProducto(ProductoSaveModel producto);
        void UpdateProducto(ProductoUpdateModel producto);
        void RemoveProducto(ProductoRemoveModel producto);
    }
}
