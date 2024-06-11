using System.Linq.Expressions;


namespace Ventas.Domain.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Save(TEntity entity);
        Task Save(List<TEntity> entities);
        Task<TEntity> Get(int Id);
        Task<List<TEntity>> GetAll(Expression<Func<TEntity,bool>> filter);
        Task Update(TEntity entity);
        Task Update(List<TEntity> entities);
        Task Delete(int Id);
        Task Delete(List<TEntity> entities);
        Task<bool> Exists (Expression<Func<TEntity,bool>> filter);

    }
}
