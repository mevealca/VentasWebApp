
namespace Ventas.Domain.Models
{
    public class VentaModel
    {
        public int Id { get; set; }
        public string? NumeroVenta { get; set; }
        public int? IdTipoDocumentoVenta { get; set; }
        public string? TipoDocumentoVenta { get; set; }
        public int? TipoDocumentoVentaId { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? NombreCliente { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ImpuestoTotal { get; set; }
        public decimal? Total { get; set; }
        public List<DetalleVentaModel>? DetalleVentaModel { get; set; }


    }
}
