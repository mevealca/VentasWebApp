

using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Ventas
{
    public class VentasUpdateModel: BaseModelUpdate
    {
        public string? NumeroVenta { get; set; }
        public int? IdTipoDocumentoVenta { get; set; }
        public int? IdUsuario { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? NombreCliente { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ImpuestoTotal { get; set; }
        public decimal? Total { get; set; }


    }
}
