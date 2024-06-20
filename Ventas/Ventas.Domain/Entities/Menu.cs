
using System.ComponentModel.DataAnnotations.Schema;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    [Table("Menu")]
    public sealed class Menu: AuditableEntity
    {
        public string? Descripcion { get; set; }
        public int? IdMenuPadre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
        public bool? EsActivo { get; set; }

        public Menu? Padre { get; set; }

    }
}
