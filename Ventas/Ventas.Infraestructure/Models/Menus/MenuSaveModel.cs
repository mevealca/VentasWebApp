
namespace Ventas.Infraestructure.Models.Menus
{
    public class MenuSaveModel
    {
        public string? Descripcion { get; set; }
        public int IdMenuPadre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
        public bool EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
