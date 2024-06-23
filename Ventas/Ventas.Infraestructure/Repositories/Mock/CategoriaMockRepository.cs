using System.Linq.Expressions;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Categorias;
using Ventas.Infraestructure.Extentions;
using Ventas.Infraestructure.Execeptions;

namespace Ventas.Infraestructure.Repositories.Mock
{
    public class CategoriaMockRepository : VentasContextInMemory, ICategoriaRepository
    {
        private VentasContext _context = null;
        public CategoriaMockRepository()
        {
            var options = CreateInMemoryDatabaseOptions();
            _context = new VentasContext(options);
        }

        public List<CategoriaModel> GetCategorias()
        {
            try
            {
                var categorias = _context.Categorias.Where(x => x.EsActivo.Value && !x.Eliminado.Value).ToList();
                return categorias.ConvertCategoriaEntityToCategoriaModel();
            }
            catch (Exception ex)
            {
                throw new CategoriaException("Categoría no existe...");
            }
        }

        public CategoriaModel GetCategoria(int categoriaId)
        {
            if (!_context.Categorias.Any(x => x.Id == categoriaId))
                throw new CategoriaException("Categoría no existe");

            var categoria = _context.Categorias.Find(categoriaId);
            return categoria.ConvertCategoriaEntityToCategoriaModel();
        }

        public void AddCategoria(CategoriaSaveModel categoria)
        {
            try
            {
                if (categoria is null || string.IsNullOrEmpty(categoria.Descripcion))
                    throw new ArgumentNullException("La categoria no puede ser nula");

                if (_context.Categorias.Any(c => c.Descripcion == categoria.Descripcion))
                    throw new CategoriaException("La categoría ya existe");

                _context.Categorias.Add(categoria.ConvertCategoriaSaveModelToCategoriaEntity());
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new CategoriaException(ex.Message);
            }


        }

        public void RemoveCategoria(CategoriaRemoveModel categoria)
        {
            try
            {
                Categoria categoriaRemove = _context.Categorias.Find(categoria.Id);

                if (categoriaRemove is null)
                    throw new CategoriaException("Categoría no existe"); ;

                categoriaRemove.Eliminado = true;
                categoriaRemove.FechaElimino = DateTime.Now;
                categoriaRemove.IdUsuarioElimino = categoria.IdUsuarioElimino;

                _context.Update(categoriaRemove);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new CategoriaException("La categoria no existe");
            }


        }

        public void UpdateCategoria(CategoriaUpdateModel categoria)
        {
            try
            {
                Categoria categoriaUpdate = _context.Categorias.Find(categoria.Id);

                if (categoriaUpdate is null)
                    throw new CategoriaException("Categoría no existe"); ;

                categoriaUpdate.EsActivo = categoria.EsActivo;
                categoriaUpdate.FechaMod = DateTime.Now;
                categoriaUpdate.IdUsuarioMod = categoria.IdUsuarioMod;
                categoriaUpdate.Descripcion = categoria.Descripcion;


                _context.Update(categoriaUpdate);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new CategoriaException("La categoria no existe");
            }


        }
        public void Save(Categoria categoria)
        {
            try
            {
                if (categoria is null || string.IsNullOrEmpty(categoria.Descripcion))
                    throw new ArgumentNullException("La categoria no puede ser nula");

                if (_context.Categorias.Any(c => c.Descripcion == categoria.Descripcion))
                    throw new CategoriaException("La categoría ya existe");

                _context.Categorias.Add(categoria);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new CategoriaException("La categoria no existe");
            }
        }

        public void Save(List<Categoria> entities)
        {
            throw new NotImplementedException();
        }

        public Categoria Get(int Id)
        {
            return _context.Categorias.Find(Id);
        }

        public List<Categoria> GetAll(Expression<Func<Categoria, bool>> filter)
        {
           return _context.Categorias.Where(filter).ToList();
        }

        public void Update(Categoria categoria)
        {
            try
            {
                Categoria categoriaUpdate = _context.Categorias.Find(categoria.Id);

                if (categoriaUpdate is null)
                    throw new CategoriaException("Categoría no existe"); ;

                categoriaUpdate.EsActivo = categoria.EsActivo;
                categoriaUpdate.FechaMod = DateTime.Now;
                categoriaUpdate.IdUsuarioMod = categoria.IdUsuarioMod;
                categoriaUpdate.Descripcion = categoria.Descripcion;


                _context.Update(categoriaUpdate);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new CategoriaException("La categoria no existe");
            }
        }

        public void Update(List<Categoria> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<Categoria> entities)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Categoria, bool>> filter)
        {
           return _context.Categorias.Any(filter);
        }

        public void Delete(Categoria categoria)
        {
            try
            {
                Categoria categoriaRemove = _context.Categorias.Find(categoria.Id);

                if (categoriaRemove is null)
                    throw new CategoriaException("Categoría no existe"); ;

                categoriaRemove.Eliminado = true;
                categoriaRemove.FechaElimino = DateTime.Now;
                categoriaRemove.IdUsuarioElimino = categoria.IdUsuarioElimino;

                _context.Update(categoriaRemove);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new CategoriaException("La categoria no existe");
            }
        }
    }
}
