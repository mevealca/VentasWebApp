
namespace Ventas.Infraestructure.Models.Menus
{
    public class MenuSaveModel
    {
        public MenuSaveModel() { 
            this.FechaRegistro = DateTime.Now;
            this.Eliminado = false;
        }
        public string? Descripcion { get; set; }
        public int IdMenuPadre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public bool Eliminado { get; set; }
    }
}
