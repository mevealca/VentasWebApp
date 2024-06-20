using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Categorias;
using Ventas.Infraestructure.Models.Ventas;

namespace Ventas.Infraestructure.Extentions
{
    public static class VentaExtentions
    {
        public static VentaModel ConvetVentaEntityToVentaModel(this Venta venta)
        {

            return new VentaModel()
            {
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
                TipoDocumentoVentaId = venta.IdTipoDocumentoVenta

            };
        }

        public static List<VentaModel> ConvetVentaEntityToVentaModel(this List<Venta> ventas)
        {
            return ventas.Select(X => X.ConvetVentaEntityToVentaModel()).ToList();
        }

        public static Venta ConvertVentaSaveModelToVentaEntity(this VentasSaveModel venta)
        {

            return new Venta()
            {
                
                Eliminado = venta.Eliminado,
                FechaRegistro = DateTime.Now,
                IdUsuarioCreacion = venta.IdUsuarioCreacion,
                DocumentoCliente = venta.DocumentoCliente,
                IdTipoDocumentoVenta= venta.IdTipoDocumentoVenta,
                ImpuestoTotal = venta.ImpuestoTotal,
                NombreCliente = venta.NombreCliente,
                NumeroVenta = venta.NumeroVenta,
                SubTotal = venta.SubTotal,
                IdUsuario = venta.IdUsuario,
                DetallesVentas = venta.DetalleVentas.ConvertDetalleVentaSafeModelToDetalleVenta(),
                Total = venta.Total,
            };
        }
    }
}
