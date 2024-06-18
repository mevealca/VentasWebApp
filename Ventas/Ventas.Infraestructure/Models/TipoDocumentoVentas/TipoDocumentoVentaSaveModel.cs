
namespace Ventas.Infraestructure.Models.TipoDocumentos
{
    public class TipoDocumentoVentaSaveModel
    {
        public TipoDocumentoVentaSaveModel() {
            this.EsActivo =true;
            this.FechaRegistro = DateTime.Now;
        }

        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }


    }
}
