

namespace Ventas.Infraestructure.Core
{
    public abstract class BaseModelRemove : BaseModel
    {
        public BaseModelRemove()
        {
            FechaElimino = DateTime.Now;
            Eliminado = true;
        }

        public DateTime FechaElimino { get; set; }
        public int IdUsuarioElimino { get; set; }
        public bool Eliminado { get; set; }
    }
}
