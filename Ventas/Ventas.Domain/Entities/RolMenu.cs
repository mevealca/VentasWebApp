
using System.ComponentModel.DataAnnotations.Schema;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    [Table("RolMenu")]
    public sealed class RolMenu:AuditableEntity
    {
        public int IdRol { get; set; }
        public int IdMenu { get; set; }
        public bool EsActivo { get; set; }
    }
}
