

namespace Ventas.Infraestructure.Models.Ventas
{
    public class VentasUpdateModel
    {
        public VentasUpdateModel() { 
        
            this.FechaMod= DateTime.Now;

        }
        public int Id { get; set; }
        public string? NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? NombreCliente { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ImpuestoTotal { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaMod { get; set; }
        public int IdUsuarioMod { get; set; }

    }
}
