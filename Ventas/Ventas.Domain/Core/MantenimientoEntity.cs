
namespace Ventas.Domain.Core
{
    public abstract class MantenimientoEntity : AuditableEntity
    {

        public string Descripcion { get; set; }
        public bool EsActivo { get; set;}
 
}
}
