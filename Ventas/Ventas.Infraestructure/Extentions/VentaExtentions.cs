using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    public static  class VentaExtentions
    {
        public static VentaModel ConvetVentaEntityToVentaModel(this Venta venta) {

            return new VentaModel() { 
                Id = venta.Id,
                DetalleVentaModel = venta.DetallesVentas.ConvertDetalleVentaEntityToDetalleVentaModel(),
                Total = venta.Total,
                DocumentoCliente = venta.DocumentoCliente,
                IdTipoDocumentoVenta = venta.IdTipoDocumentoVenta,
                ImpuestoTotal = venta.ImpuestoTotal,
                NombreCliente = venta.NombreCliente,
                NumeroVenta = venta.NumeroVenta,
                SubTotal = venta.SubTotal,
                TipoDocumentoVenta = venta.TipoDocumentoVenta.Descripcion,
                TipoDocumentoVentaId=venta.IdTipoDocumentoVenta

            };
        }
    }
}
