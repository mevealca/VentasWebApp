using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Execeptions;
using Ventas.Infraestructure.Extentions;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Usuarios;

namespace Ventas.Infraestructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly VentasContext _context; 
        private readonly ILogger<UsuarioRepository> _logger;
        public UsuarioRepository(VentasContext context,ILogger<UsuarioRepository> logger) : base(context)
        {
            _logger = logger;
            _context = context;
        }

        public void AddUsuario(UsuarioSaveModel usuario)
        {
            try
            {
                if (usuario is null || string.IsNullOrEmpty(usuario.Nombre))
                    throw new ArgumentNullException("El usuario no puede ser nulo");

                if (base.Exists(c => c.Nombre == usuario.Nombre))
                    throw new UsuarioException("El Usuario ya existe");

                base.Save(usuario.ConvertUsuarioModelToUsuarioEntity());
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error agregando el usuario ${ex.Message}", ex.ToString());
                throw new UsuarioException("El usuario no existe");
            }
        }

        public UsuarioModel GetUsuario(int usuarioId)
        {
            try
            {
                if (!base.Exists(x => x.Id == usuarioId))
                    throw new UsuarioException("Usuario no existe");

                var usuario = base.Get(usuarioId).ConvertUsuarioEntityToUsuarioModel();
                return usuario;
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error consultando el usuario:{ex.Message}", ex.ToString());
                throw new UsuarioException("Usuario no existe"); ;
            }
        }

        public List<UsuarioModel> GetUsuarios()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            try
            {
                usuarios = base.GetAll(x => x.EsActivo.Value && !x.Eliminado.Value).ToList().ConvertUsuarioEntityToUsuarioModel();
            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error consultando los usuarios:{ex.Message}", ex.ToString());
                throw new UsuarioException("Usuario no existe...");
            }

            return usuarios;
        }

        public void RemoveUsuario(UsuarioRemoveModel usuario)
        {
            try
            {
                Usuario usuarioRemove = base.Get(usuario.Id);

                if (usuarioRemove is null)
                    throw new UsuarioException("Usuario no existe"); ;

                usuarioRemove.Eliminado = true;
                usuarioRemove.FechaElimino = DateTime.Now;
                usuarioRemove.IdUsuarioElimino = usuario.IdUsuarioElimino;

                base.Update(usuarioRemove);
                base.SaveChanges();

            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error eliminando el usuario ${ex.Message}", ex.ToString());
                throw new UsuarioException("El usuario no existe");
            }
        }

        public void UpdateUsuario(UsuarioUpdateModel usuario)
        {
            try
            {
                Usuario usuarioUpdate = base.Get(usuario.Id);

                if (usuarioUpdate is null)
                    throw new UsuarioException("Usuario no existe"); ;

                usuarioUpdate.EsActivo = usuario.EsActivo;
                usuarioUpdate.FechaMod = DateTime.Now;
                usuarioUpdate.IdUsuarioMod = usuario.IdUsuarioMod;
                usuarioUpdate.Nombre = usuario.Nombre;
                usuarioUpdate.NombreFoto = usuario.NombreFoto;
                usuarioUpdate.UrlFoto = usuario.UrlFoto;
                usuarioUpdate.Clave = usuario.Clave;
                usuarioUpdate.Correo = usuario.Correo;
                usuarioUpdate.IdRol = usuario.IdRol ;


                base.Update(usuarioUpdate);
                base.SaveChanges();

            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error actualizando el usuario ${ex.Message}", ex.ToString());
                throw new UsuarioException("El usuario no existe");
            }
        }
    }
}
