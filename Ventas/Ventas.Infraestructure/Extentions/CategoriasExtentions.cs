
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

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

            return categoria.ConvertCategoriaEntityToCategoriaModel();

        }
    }
}
