
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Extentions;
using Microsoft.Extensions.Logging;
using Ventas.Infraestructure.Execeptions;
using Ventas.Infraestructure.Models.Categorias;
namespace Ventas.Infraestructure.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        private readonly VentasContext _context;
        private readonly ILogger<CategoriaRepository> _logger;
        public CategoriaRepository(VentasContext context, ILogger<CategoriaRepository>logger) : base(context)
        {
            this._context = context;
            this._logger = logger;
        }

        public  List<CategoriaModel> GetCategorias()
        {
            //List<CategoriaModel> categorias = new List<CategoriaModel>();
            try
            {
                var categorias = base.GetAll(x => x.EsActivo.Value && !x.Eliminado.Value).ToList();
                return categorias.ConvertCategoriaEntityToCategoriaModel(); 
            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error consultando las categorias:{ex.Message}", ex.ToString());
                throw new CategoriaException("Categoría no existe...");
            }

            

        }

        public CategoriaModel GetCategoria(int categoriaId) {

            try
            {
                if (!base.Exists(x => x.Id == categoriaId))
                    throw new CategoriaException("Categoría no existe");

                var categoria = base.Get(categoriaId).ConvertCategoriaEntityToCategoriaModel();
                return categoria;
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error consultando las categorias:{ex.Message}", ex.ToString());
                 throw new CategoriaException("Categoría no existe"); ;
            }
        }

        public void AddCategoria(CategoriaSaveModel categoria) {
            try
            {
                if (categoria is null || string.IsNullOrEmpty(categoria.Descripcion))
                    throw new ArgumentNullException("La categoria no puede ser nula");

                if (base.Exists(c => c.Descripcion == categoria.Descripcion))
                    throw new CategoriaException("La categoría ya existe");

                base.Save(categoria.ConvertCategoriaSaveModelToCategoriaEntity());
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error agregando la categoría ${ex.Message}", ex.ToString());
                throw new CategoriaException("La categoria no existe");
            }
           
        
        }

        public void RemoveCategoria(CategoriaRemoveModel categoria) {
            try
            {
                Categoria categoriaRemove = base.Get(categoria.Id);
                
                if (categoriaRemove is null)
                    throw new CategoriaException("Categoría no existe"); ;

                categoriaRemove.Eliminado = true;
                categoriaRemove.FechaElimino = DateTime.Now;
                categoriaRemove.IdUsuarioElimino = categoria.IdUsuarioElimino;

                base.Update(categoriaRemove);
                base.SaveChanges();

            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error eliminando la categoría ${ex.Message}", ex.ToString());
                throw new CategoriaException("La categoria no existe");
            }
            

        }

        public void UpdateCategoria(CategoriaUpdateModel categoria)
        {
            try
            {
                Categoria categoriaUpdate = base.Get(categoria.Id);

                if (categoriaUpdate is null)
                    throw new CategoriaException("Categoría no existe"); ;

                categoriaUpdate.EsActivo = categoria.EsActivo;
                categoriaUpdate.FechaMod = DateTime.Now;
                categoriaUpdate.IdUsuarioMod = categoria.IdUsuarioMod;
                categoriaUpdate.Descripcion = categoria.Descripcion;
        

                base.Update(categoriaUpdate);
                base.SaveChanges();

            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error actualizando la categoría ${ex.Message}", ex.ToString());
                throw new CategoriaException("La categoria no existe");
            }


        }

    }
}
