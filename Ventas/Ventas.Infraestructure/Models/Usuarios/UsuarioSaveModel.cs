

namespace Ventas.Infraestructure.Models.Usuarios
{
    public class UsuarioSaveModel
    {
        public UsuarioSaveModel() {
            this.Eliminado = false;
            this.EsActivo = true;
            this.FechaRegistro = DateTime.Now;
        }

        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? UrlFoto { get; set; }
        public string? NombreFoto { get; set; }
        public string? Clave { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public bool? Eliminado { get; set; }

    }
}
