
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public sealed class RolMenu:AuditableEntity
    {
        public int IdRol { get; set; }
        public int IdMenu { get; set; }
        public bool EsActivo { get; set; }
    }
}
