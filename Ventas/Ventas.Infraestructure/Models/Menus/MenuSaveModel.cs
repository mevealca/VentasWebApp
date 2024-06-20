
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Menus
{
    public class MenuSaveModel :BaseModelSave
    {
        public int IdMenuPadre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
    }
}
