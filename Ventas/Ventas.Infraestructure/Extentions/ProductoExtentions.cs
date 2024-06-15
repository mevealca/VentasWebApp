
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    public static class ProductoExtentions
    {
        public static ProductoModel ConvertProductoEntityToProductoModel(this Producto producto) {

            return new ProductoModel() { 
                Id = producto.Id,
                CodigoBarra=producto.CodigoBarra,
                Categoria=producto.Categoria.Descripcion,
                Descripcion=producto.Descripcion,
                IdCategoria=producto.IdCategoria,
                EsActivo=producto.EsActivo,
                Marca=producto.Marca,
                NombreImagen=producto.NombreImagen,
                Stock = producto.Stock,
                UrlImagen = producto.UrlImagen
            };
        }
    }
}
