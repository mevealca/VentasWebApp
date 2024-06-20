
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Menus
{
    public class MenuUpdateModel : BaseModelUpdate
    {
        public string? Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public string? ICono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set;}
    }
}
