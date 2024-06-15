using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    public static class VentasDetalleExtentions
    {
        public static DetalleVentaModel ConvertDetalleVentaEntityToDetalleVentaModel(this DetalleVenta detalleVenta) {

            return new DetalleVentaModel() { 
                Id = detalleVenta.Id,
                Cantidad = detalleVenta.Cantidad,
                CategoriaProducto= detalleVenta.CategoriaProducto,
                DescripcionProducto = detalleVenta.DescripcionProducto,
                IdProducto = detalleVenta.IdProducto,
                IdVenta = detalleVenta.IdVenta,
                MarcaProducto = detalleVenta.MarcaProducto,
                Precio = detalleVenta.Precio,
                Total = detalleVenta.Total
            };
        }
        public static List<DetalleVentaModel> ConvertDetalleVentaEntityToDetalleVentaModel(this List<DetalleVenta> detalleVenta) { 
        
            return detalleVenta.ConvertDetalleVentaEntityToDetalleVentaModel();
        }
    }
}
