using System;
using System.Data.Entity;
using System.Linq;

namespace Repository.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class 
    {
        public DbContext Context { get; set; }

        public GenericRepository(DbContext context)
        {
            Context = context;
        }

        //Create
        public void Create(TEntity t)
        {
            Context.Set<TEntity>().Add(t);
        }
        //Read

        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).AsQueryable();
        }

        //Update
        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        //Delete
        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void SaveAll()
        {
            Context.SaveChanges();
        }
    }
}
