using System;
using System.Linq;

namespace Repository.Infrastructure.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity t);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll(Func<TEntity, bool> predicate);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void SaveAll();
    }
}