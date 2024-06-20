
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Categorias;
using Ventas.Infraestructure.Models.Productos;

namespace Ventas.Infraestructure.Extentions
{
    public static class ProductoExtentions
    {
        public static ProductoModel ConvertProductoEntityToProductoModel(this Producto producto) {

            return new ProductoModel() { 
                Id = producto.Id,
                CodigoBarra=producto.CodigoBarra,
                Categoria=producto.Categoria?.Descripcion,
                Descripcion=producto.Descripcion,
                IdCategoria=producto.IdCategoria,
                EsActivo=producto.EsActivo,
                Marca=producto.Marca,
                NombreImagen=producto.NombreImagen,
                Stock = producto.Stock,
                UrlImagen = producto.UrlImagen
            };
        }

        public static List<ProductoModel> ConvertProductoEntityToProductoModel(this List<Producto> producto) { 
        
            return producto.Select(X => X.ConvertProductoEntityToProductoModel()).ToList();
        
        }


        public static Producto ConvertProductoSaveModelToProductoEntity(this ProductoSaveModel producto)
        {

            return new Producto()
            {
                Descripcion = producto.Descripcion,
                EsActivo = producto.EsActivo,
                Eliminado = producto.Eliminado,
                FechaRegistro = producto.FechaRegistro,
                IdUsuarioCreacion = producto.IdUsuarioCreacion,
                CodigoBarra = producto.CodigoBarra,
                IdCategoria = producto.IdCategoria,
                Marca = producto.Marca,
                Precio = producto.Precio,
                Stock= producto.Stock,
                NombreImagen= producto.NombreImagen,
                UrlImagen= producto.UrlImagen,
            };
        }
    }
}
