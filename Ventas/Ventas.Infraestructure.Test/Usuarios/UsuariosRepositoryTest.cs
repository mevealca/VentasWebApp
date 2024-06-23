using Ventas.Domain.Models;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Usuarios;
using Ventas.Infraestructure.Repositories.Mock;

namespace Ventas.Infraestructure.Unit.Test.Usuarios
{
    public class UsuariosRepositoryTest
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuariosRepositoryTest() { 
        
            _usuarioRepository= new UsuariosMockRepository();
        }

        [Fact]
        public void GetUsuario_witValidateUsuarioModel() { 
        
            //Arrange

                var entity = this._usuarioRepository.GetUsuarios();

            //Expect
                
            //Asert
            Assert.NotNull(entity);
            Assert.IsType<List<UsuarioModel>>(entity);
        }

        [Fact]
        public void GetUsuarioById()
        {

            //Arrange
            var entitySave = new UsuarioSaveModel()
            {
               Nombre = "Usuario",
               Clave = "123456",
               Correo="prueba@hotmail.com",
               IdRol = 1,
               Telefono = "8094523545",
               IdUsuarioCreacion = 1,
               EsActivo= true
            };
            var entity = new UsuarioModel()
            {
                Id = 1,
                Nombre = "Usuario",
                Correo = "prueba@hotmail.com",
                IdRol = 1
            };

            //Expect
            this._usuarioRepository.AddUsuario(entitySave);
            var result = this._usuarioRepository.GetUsuario(1);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(entity.Nombre, result.Nombre);
        }

        [Fact]
        public void ASaveUsuario_withValidUsuarioModel()
        {

            //Arrange

            var entitySave = new UsuarioSaveModel()
            {
                Nombre = "Usuario",
                Clave = "123456",
                Correo = "prueba@hotmail.com",
                IdRol = 1,
                Telefono = "8094523545"
            };

            //Expect

            //Assert
            Assert.NotNull(entitySave);
            Assert.IsType<UsuarioSaveModel>(entitySave);
            Assert.Single(this._usuarioRepository.GetUsuarios());
        }

    }
}
