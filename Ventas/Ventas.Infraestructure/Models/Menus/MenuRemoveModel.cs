

namespace Ventas.Infraestructure.Models.Menus
{
    public class MenuRemoveModel
    {
        public MenuRemoveModel() { 
            this.FechaElimino = DateTime.Now;
            this.Eliminado=true;
        
        }
        public int Id { get; set; }
        public DateTime? FechaElimino { get; set; }
        public bool Eliminado { get; set; }
        public int? IdUsuarioEliminado { get; set; }
    }
}
