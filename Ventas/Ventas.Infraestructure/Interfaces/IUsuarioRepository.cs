using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.TipoDocumentos;
using Ventas.Infraestructure.Models.TipoDocumentoVentas;
using Ventas.Infraestructure.Models.Usuarios;

namespace Ventas.Infraestructure.Interfaces
{
    public interface IUsuarioRepository: IBaseRepository<Usuario>
    {
        List<UsuarioModel> GetUsuarios();
        UsuarioModel GetUsuario(int usuarioId);
        void AddUsuario(UsuarioSaveModel usuario);
        void UpdateUsuario(UsuarioUpdateModel usuario);
        void RemoveUsuario(UsuarioRemoveModel usuario);
    }
}
