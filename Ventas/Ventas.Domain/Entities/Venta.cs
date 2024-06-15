
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public sealed class Venta: AuditableEntity
    {
        public string? NumeroVenta { get; set; }
        public int? IdTipoDocumentoVenta { get; set; }
        public int? IUsuario { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? NombreCliente { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ImpuestoTotal { get; set; }
        public decimal? Total { get; set; }
        public List<DetalleVenta>? DetallesVentas { get; set; }
        public TipoDocumentoVenta TipoDocumentoVenta { get; set; }

    }
}
