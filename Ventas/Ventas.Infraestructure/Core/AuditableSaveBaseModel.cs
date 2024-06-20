

namespace Ventas.Infraestructure.Core
{
    public abstract class AuditableSaveBaseModel
    {
        public AuditableSaveBaseModel()
        {
            Eliminado = false;
            FechaRegistro = DateTime.Now;
        }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public bool? Eliminado { get; set; }
    }
}
