
namespace Ventas.Infraestructure.Models.Ventas
{
    public class VentasRemoveModel
    {
        public VentasRemoveModel() {
            this.FechaElimino = DateTime.Now;
            this.Eliminado = true;
        }
        public int Id { get; set; }
        public DateTime? FechaElimino { get; set; }
        public int IdUsuarioElimino { get; set; }
        public bool Eliminado { get; set; }
    }
}
