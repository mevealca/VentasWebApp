

namespace Ventas.Infraestructure.Models.Categorias
{
    public class CategoriaRemoveModel
    {
        public CategoriaRemoveModel() {
            this.FechaElimino = DateTime.Now;
            this.Eliminado = true;
        }   
        public int Id { get; set; }
        public DateTime FechaElimino { get; set; }
        public int IdUsuarioEliminado { get; set; }
        public bool Eliminado { get; set; }
    }
}
