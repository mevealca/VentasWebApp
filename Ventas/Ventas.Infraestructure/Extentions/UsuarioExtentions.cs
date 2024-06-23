
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Usuarios;

namespace Ventas.Infraestructure.Extentions
{
    public static class UsuarioExtentions
    {
        public static UsuarioModel ConvertUsuarioEntityToUsuarioModel(this Usuario usuario)
        {

            return new UsuarioModel()
            {
                Id = usuario.Id,
                Correo = usuario?.Correo,
                IdRol = usuario?.IdRol,
                Nombre = usuario?.Nombre,
                Rol = usuario?.Rol?.Descripcion,
                Telefono = usuario?.Telefono
            };
        }
        public static List<UsuarioModel> ConvertUsuarioEntityToUsuarioModel(this List<Usuario> usuario)
        {
            return usuario.Select(x => x.ConvertUsuarioEntityToUsuarioModel()).ToList();
        }

        public  static Usuario ConvertUsuarioModelToUsuarioEntity(this UsuarioSaveModel usuario) {

            return new Usuario()
            {
                Correo = usuario.Correo,
                IdRol = usuario?.IdRol,
                Nombre = usuario?.Nombre,
                Telefono = usuario?.Telefono,
                Clave   =usuario?.Clave,
                FechaRegistro =usuario?.FechaRegistro,
                IdUsuarioCreacion= usuario?.IdUsuarioCreacion,
                NombreFoto = usuario?.NombreFoto,
                UrlFoto = usuario?.UrlFoto,
                EsActivo = usuario?.EsActivo,
                Eliminado = usuario?.Eliminado
            };
        }
    }
}
