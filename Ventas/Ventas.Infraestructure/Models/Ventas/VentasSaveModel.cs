
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Models.Ventas
{
    public class VentasSaveModel
    {
        public VentasSaveModel() { 
            this.FechaRegistro = DateTime.Now;
            this.Eliminado =false;
        }

        public string? NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? NombreCliente { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ImpuestoTotal { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public bool Eliminado { get; set; }
        public List<DetalleVentaModel>? DetalleVentas { get; set; }

    }
}
