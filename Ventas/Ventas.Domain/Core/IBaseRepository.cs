using System.Linq.Expressions;


namespace Ventas.Domain.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Save(TEntity entity);
        Task<List<TEntity>> Save(List<TEntity> entities);
        Task<TEntity> Get(int Id);
        Task<List<TEntity>> GetAll(Expression<Func<TEntity,bool>> filter);
        Task<TEntity> Update(TEntity entity);
        Task<List<TEntity>> Update(List<TEntity> entities);
        Task<TEntity> Delete(int Id);
        Task<List<TEntity>> Delete(List<TEntity> entities);
        Task<bool> Exists (Expression<Func<TEntity,bool>> filter);

    }
}
