
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

        public virtual async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
           return await this._entities.AnyAsync(filter);
        }

        public virtual async Task<TEntity> Get(int id)
        {
            return await this._entities.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return await this._entities.Where(filter).ToListAsync();
        }

        public virtual async Task Save(TEntity entity)
        {
             this._entities.Add(entity);
            await this._context.SaveChangesAsync();
        }

        public virtual async Task Save(List<TEntity> entities)
        {
             this._entities.AddRange(entities);
            await this._context.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
                  this._entities.Update(entity);
            await this._context.SaveChangesAsync();
        }

        public virtual async Task Update(List<TEntity> entities)
        {
            this._entities.UpdateRange(entities);
            await this._context.SaveChangesAsync();
        }
        public virtual async Task Delete(int Id)
        {
            var entity = await this._entities.FindAsync(Id);
            this._entities.Remove(entity);
            await this._context.SaveChangesAsync();

        }

        public virtual async Task Delete(List<TEntity> entities)
        {
            this._entities.RemoveRange(entities);
            await this._context.SaveChangesAsync();
        }
    }
}
