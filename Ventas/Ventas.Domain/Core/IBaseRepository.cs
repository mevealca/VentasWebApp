using System.Linq.Expressions;


namespace Ventas.Domain.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Save(List<TEntity> entities);
        TEntity Get(int Id);
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter);
        void Update(TEntity entity);
        void Update(List<TEntity> entities);
        void Delete(int Id);
        void Delete(List<TEntity> entities);
        bool Exists (Expression<Func<TEntity,bool>> filter);

    }
}
