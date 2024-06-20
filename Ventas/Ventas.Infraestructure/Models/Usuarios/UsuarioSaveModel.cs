

using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Usuarios
{
    public class UsuarioSaveModel :BaseModelSave
    {
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? UrlFoto { get; set; }
        public string? NombreFoto { get; set; }
        public string? Clave { get; set; }
        public int IdRol { get; set; }
    }
}
