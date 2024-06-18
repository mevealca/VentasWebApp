
namespace Ventas.Infraestructure.Models.TipoDocumentoVentas
{
    public class TipoDocumentoVentaRemoveModel
    {
        public TipoDocumentoVentaRemoveModel() { 
            this.Eliminado = true;
            this.FechaElimino = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime FechaElimino { get; set; }
        public int IdUsuarioElimino { get; set; }
        public bool Eliminado { get; set; }
    }
}
