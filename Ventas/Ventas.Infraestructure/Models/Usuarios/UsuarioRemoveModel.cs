
namespace Ventas.Infraestructure.Models.Usuarios
{
    public class UsuarioRemoveModel
    {
        public UsuarioRemoveModel() {

            this.Eliminado=true;
            this.FechaEliminado= DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime? FechaEliminado { get; set; }
        public int IdUsuarioEliminado { get; set; }
        public bool Eliminado { get; set; }
    }
}
