
namespace Ventas.Domain.Core
{
    public abstract class MantenimientoEntity : AuditableEntity
    {
        protected MantenimientoEntity() {
            this.EsActivo = true;
        }
        public string? Descripcion { get; set; }
        public bool EsActivo { get; set;}
 
}
}
