

namespace Ventas.Infraestructure.Models.Usuarios
{
    public class UsuarioUpdateModel
    {
        public UsuarioUpdateModel() { 
            this.FechaMod=DateTime.Now;

        }
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? UrlFoto { get; set; }
        public string? NombreFoto { get; set; }
        public string? Clave { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaMod { get; set; }
        public int? IdUsuarioCreacion { get; set; }
    }
}
