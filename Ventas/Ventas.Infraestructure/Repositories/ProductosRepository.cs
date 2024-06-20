
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Microsoft.Extensions.Logging;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Execeptions;
using Ventas.Infraestructure.Extentions;
using Ventas.Infraestructure.Models.Productos;

namespace Ventas.Infraestructure.Repositories
{
    public class ProductosRepository: BaseRepository<Producto>, IProductoRepository
    {
        private readonly VentasContext _context;
        private readonly ILogger<ProductosRepository> _logger;

        public ProductosRepository(VentasContext context, ILogger<ProductosRepository> logger) : base(context)
        {
            this._context = context;
            this._logger = logger;
        }

      
        public List<ProductoModel> GetProductos()
        {
            List<ProductoModel> productos = new List<ProductoModel>();
            try
            {
                productos = base.GetAll(x => x.EsActivo.Value && !x.Eliminado.Value).ToList().ConvertProductoEntityToProductoModel();
            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error consultando los productos:{ex.Message}", ex.ToString());
                throw new ProductoException("Producto no existe...");
            }

            return productos;

        }

        public ProductoModel GetProducto(int productoId)
        {

            try
            {
                if (!base.Exists(x => x.Id == productoId))
                    throw new ProductoException("Producto no existe");

                var producto = base.Get(productoId).ConvertProductoEntityToProductoModel();
                return producto;
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error consultando el producto:{ex.Message}", ex.ToString());
                throw new ProductoException("Producto no existe"); ;
            }
        }

        public void AddProducto(ProductoSaveModel producto)
        {
            try
            {
                if (producto is null || string.IsNullOrEmpty(producto.Descripcion))
                    throw new ArgumentNullException("El producto no puede ser nulo");

                if (base.Exists(c => c.Descripcion == producto.Descripcion))
                    throw new ProductoException("El producto ya existe");

                base.Save(producto.ConvertProductoSaveModelToProductoEntity());
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error agregando el producto ${ex.Message}", ex.ToString());
                throw new ProductoException("El producto no existe");
            }


        }

        public void RemoveProducto(ProductoRemoveModel producto)
        {
            try
            {
                Producto productoRemove = base.Get(producto.Id);

                if (productoRemove is null)
                    throw new ProductoException("Producto no existe"); ;

                productoRemove.Eliminado = true;
                productoRemove.FechaElimino = DateTime.Now;
                productoRemove.IdUsuarioElimino = producto.IdUsuarioElimino;

                base.Update(productoRemove);
                base.SaveChanges();

            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error eliminando el producto ${ex.Message}", ex.ToString());
                throw new ProductoException("El producto no existe");
            }


        }

        public void UpdateProducto(ProductoUpdateModel producto)
        {
            try
            {
                Producto productoUpdate = base.Get(producto.Id);

                if (productoUpdate is null)
                    throw new ProductoException("Producto no existe"); ;

                productoUpdate.EsActivo = producto.EsActivo;
                productoUpdate.FechaMod = DateTime.Now;
                productoUpdate.IdUsuarioMod = producto.IdUsuarioMod;
                productoUpdate.Descripcion = producto.Descripcion;
                productoUpdate.CodigoBarra = producto.CodigoBarra;
                productoUpdate.Marca = producto.Marca;
                productoUpdate.IdCategoria = producto.IdCategoria;
                productoUpdate.NombreImagen = producto.NombreImagen;
                productoUpdate.UrlImagen = producto.UrlImagen;
                productoUpdate.Stock = producto.Stock;
                productoUpdate.Precio = producto.Precio;

                base.Update(productoUpdate);
                base.SaveChanges();

            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error actualizando el producto ${ex.Message}", ex.ToString());
                throw new ProductoException("El producto no existe");
            }


        }

    




}
}
