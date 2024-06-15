

using Ventas.Domain.Core;

namespace Ventas.Domain.Models
{
    public class MenuModel :BaseModels
    {
        public int? IdPadre { get; set; }
        public string? Padre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
    }
}
