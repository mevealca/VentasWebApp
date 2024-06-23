using System.Linq.Expressions;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Execeptions;
using Ventas.Infraestructure.Extentions;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Usuarios;

namespace Ventas.Infraestructure.Repositories.Mock
{
    public class UsuariosMockRepository : VentasContextInMemory, IUsuarioRepository
    {
        private VentasContext _context = null;
        public UsuariosMockRepository() { 
            var options = CreateInMemoryDatabaseOptions();
            _context = new VentasContext(options);
        }
        public void AddUsuario(UsuarioSaveModel usuario)
        {
            try
            {
                if (usuario is null || string.IsNullOrEmpty(usuario.Nombre))
                    throw new ArgumentNullException("El usuario no puede ser nulo");

                if (_context.Usuarios.Any(c => c.Nombre == usuario.Nombre))
                    throw new UsuarioException("El Usuario ya existe");

               _context.Usuarios.Add(usuario.ConvertUsuarioModelToUsuarioEntity());
               _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new UsuarioException("El usuario no existe");
            }
        }

        public void Delete(Usuario Id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Usuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll(Expression<Func<Usuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel GetUsuario(int usuarioId)
        {
            try
            {
                if (!_context.Usuarios.Any(x => x.Id == usuarioId))
                    throw new UsuarioException("Usuario no existe");

                var usuario = _context.Usuarios.Find(usuarioId).ConvertUsuarioEntityToUsuarioModel();
                return usuario;
            }
            catch (Exception ex)
            {
                throw new UsuarioException(ex.Message); ;
            }
        }

        public List<UsuarioModel> GetUsuarios()
        {
            
            try
            {
              var usuarios = _context.Usuarios.Where(x => x.EsActivo.Value && !x.Eliminado.Value).ToList();
                return usuarios.ConvertUsuarioEntityToUsuarioModel();
            }
            catch (Exception ex)
            {
                throw new UsuarioException(ex.Message);
            }

           
        }

        public void RemoveUsuario(UsuarioRemoveModel usuario)
        {
            try
            {
                Usuario usuarioRemove = _context.Usuarios.Find(usuario.Id);

                if (usuarioRemove is null)
                    throw new UsuarioException("Usuario no existe"); ;

                usuarioRemove.Eliminado = true;
                usuarioRemove.FechaElimino = DateTime.Now;
                usuarioRemove.IdUsuarioElimino = usuario.IdUsuarioElimino;

                _context.Update(usuarioRemove);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
               throw new UsuarioException("El usuario no existe");
            }
        }

        public void Save(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Save(List<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(List<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsuario(UsuarioUpdateModel usuario)
        {
            try
            {
                Usuario usuarioUpdate = _context.Usuarios.Find(usuario.Id);

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
                usuarioUpdate.IdRol = usuario.IdRol;


                _context.Update(usuarioUpdate);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new UsuarioException("El usuario no existe");
            }
        }
    }
}
