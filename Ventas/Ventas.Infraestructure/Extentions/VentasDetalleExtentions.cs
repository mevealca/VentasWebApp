using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.DetalleVentas;

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
        
            return detalleVenta.Select(X => X.ConvertDetalleVentaEntityToDetalleVentaModel()).ToList();
        }

        public static DetalleVenta ConvertDetalleVentaSafeModelToDetalleVenta(this DetalleVentaSaveModel detalleVenta) {

            return new DetalleVenta()
            {

                Cantidad = detalleVenta.Cantidad,
                CategoriaProducto = detalleVenta.CategoriaProducto,
                DescripcionProducto = detalleVenta.DescripcionProducto,
                IdProducto = detalleVenta.IdProducto,
                IdVenta = detalleVenta.IdVenta,
                MarcaProducto = detalleVenta.MarcaProducto,
                Precio = detalleVenta.Precio,
                Total = detalleVenta.Total,
            };
        
        }
        public static List<DetalleVenta> ConvertDetalleVentaSafeModelToDetalleVenta(this List<DetalleVentaSaveModel> detallesVentas) {

            return detallesVentas.Select(X => X.ConvertDetalleVentaSafeModelToDetalleVenta()).ToList();
        }

    }
}


