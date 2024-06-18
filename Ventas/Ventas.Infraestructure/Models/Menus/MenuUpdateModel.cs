
namespace Ventas.Infraestructure.Models.Menus
{
    public class MenuUpdateModel
    {
        public MenuUpdateModel() { 
            this.FechaMod = DateTime.Now;

        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public string? ICono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set;}
        public DateTime? FechaMod { get; set; }
        public int IdUsuarioMod { get; set; }
    }
}
