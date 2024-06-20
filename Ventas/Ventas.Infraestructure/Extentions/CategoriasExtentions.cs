
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Categorias;

namespace Ventas.Infraestructure.Extentions
{
    public static class CategoriasExtentions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static CategoriaModel ConvertCategoriaEntityToCategoriaModel(this Categoria categoria) {

            return new CategoriaModel
            {
                Id = categoria.Id,
                Descripcion = categoria.Descripcion,
                EsActivo = categoria.EsActivo
            };
        
        }
        /// <summary>
        /// Metodo para convertir de la entidad categoria a categoria model
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static List<CategoriaModel> ConvertCategoriaEntityToCategoriaModel(this List<Categoria> categoria)
        {

            return categoria.Select(categoria=>categoria.ConvertCategoriaEntityToCategoriaModel()).ToList();
        }

        public static Categoria ConvertCategoriaSaveModelToCategoriaEntity(this CategoriaSaveModel categoria) {

            return new Categoria()
            {
                Descripcion =categoria.Descripcion,
                EsActivo = categoria.EsActivo,
                Eliminado = categoria.Eliminado,
                FechaRegistro = categoria.FechaRegistro,
                IdUsuarioCreacion = categoria.IdUsuarioCreacion
            };
        }
    }
}
