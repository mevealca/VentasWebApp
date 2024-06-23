

using Microsoft.EntityFrameworkCore;
using Moq;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Execeptions;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Categorias;
using Ventas.Infraestructure.Repositories;
using Ventas.Infraestructure.Repositories.Mock;

namespace Ventas.Infraestructure.Test.Categorias
{
   
    public class CategoriaRepositoryTest
    {
        private ICategoriaRepository _categoriaRepository;

        public CategoriaRepositoryTest()
        {
            _categoriaRepository = new CategoriaMockRepository();
        }

        [Fact]
        public void GetCategoria_withValidCategoriaModel() {
            //Arrange
                var categorias = this._categoriaRepository.GetCategorias();

            //Expect

            //Assert

            Assert.NotNull(categorias);
            Assert.IsType<List<CategoriaModel>>(categorias);
        }


        [Fact]
        public void GetCategoriaById()
        {

            //Arrange
            var entitySave = new CategoriaSaveModel()
            {
                EsActivo = true,
                Descripcion = "Religioso",
                IdUsuarioCreacion = 1
            };
            var entity = new CategoriaModel()
            {
                EsActivo = true,
                Descripcion = "Religioso",
                Id = 1
            };

            //Expect
            this._categoriaRepository.AddCategoria(entitySave);
            var result = this._categoriaRepository.GetCategoria(1);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(entity.Descripcion, result.Descripcion);
        }


        [Fact]
        public void ASaveCategoria_withValidCategoriaModel() 
        { 
        
            //Arrange

            var entity = new CategoriaSaveModel() { 
            EsActivo = true,
            Descripcion = "Religioso",
            IdUsuarioCreacion = 1
            };

            //Expect

            //Assert
            Assert.NotNull(entity);
            Assert.IsType<CategoriaSaveModel>(entity);
            Assert.Single(this._categoriaRepository.GetCategorias());
        }



    }
}
