

namespace Ventas.Infraestructure.Models.Categorias
{
    public class CategoriaSaveModel
    {
        public CategoriaSaveModel() { 
            this.FechaRegistro = DateTime.Now;
            this.Eliminado = false;
        } 
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public bool? Eliminado { get; set; }
    }
}
