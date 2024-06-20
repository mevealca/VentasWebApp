
using Ventas.Domain.Models;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Models.DetalleVentas;

namespace Ventas.Infraestructure.Models.Ventas
{
    public class VentasSaveModel :AuditableSaveBaseModel
    {
        public string? NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? NombreCliente { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ImpuestoTotal { get; set; }
        public decimal? Total { get; set; }
        public int? IdUsuario { get; set; }
        public List<DetalleVentaSaveModel>? DetalleVentas { get; set; }

    }
}
