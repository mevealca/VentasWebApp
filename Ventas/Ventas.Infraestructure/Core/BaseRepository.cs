
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Ventas.Domain.Core;
using Ventas.Infraestructure.Context;

namespace Ventas.Infraestructure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
       private readonly VentasContext _context;
        private DbSet<TEntity> _entities;

        public BaseRepository(VentasContext context)
        {
            this._context = context;
            this._entities = this._context.Set<TEntity>();
        }

        public virtual  bool Exists(Expression<Func<TEntity, bool>> filter)
        {
           return  this._entities.Any(filter);
        }

        public virtual  TEntity Get(int id)
        {
            return  this._entities.Find(id);
        }

        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return  this._entities.Where(filter).ToList();
        }

        public virtual void Save(TEntity entity)
        {
             this._entities.Add(entity);
             this._context.SaveChanges();
        }

        public virtual void Save(List<TEntity> entities)
        {
             this._entities.AddRange(entities);
             this._context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
                  this._entities.Update(entity);
             this._context.SaveChanges();
        }

        public virtual void Update(List<TEntity> entities)
        {
            this._entities.UpdateRange(entities);
             this._context.SaveChangesAsync();
        }
        public virtual void Delete(TEntity Id)
        {
            var entity =  this._entities.Find(Id);
            this._entities.Remove(entity);
             this._context.SaveChanges();

        }

        public virtual void Delete(List<TEntity> entities)
        {
            this._entities.RemoveRange(entities);
             this._context.SaveChanges();
        }
        public virtual void SaveChanges()
        {
            this._context.SaveChanges();
        }
    }
}
