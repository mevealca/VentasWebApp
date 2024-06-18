

namespace Ventas.Infraestructure.Models.TipoDocumentoVentas
{
    public class TipoDocumentoVentaUpdateModel
    {
        public TipoDocumentoVentaUpdateModel()
        {
            this.FechaMod = DateTime.Now;
        }

        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaMod { get; set; }
        public int IdUsuarioMod { get; set; }
    }
}
