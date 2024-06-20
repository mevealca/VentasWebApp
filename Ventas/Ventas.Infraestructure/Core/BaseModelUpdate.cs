

namespace Ventas.Infraestructure.Core
{
    public abstract class BaseModelUpdate : BaseModel
    {
        public BaseModelUpdate()
        {
            FechaMod = DateTime.Now;
        }

        public DateTime? FechaMod { get; set; }
        public int? IdUsuarioMod { get; set; }
    }
}
