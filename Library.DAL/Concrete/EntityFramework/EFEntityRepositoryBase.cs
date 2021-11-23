using Library.DAL.Abstract;
using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Concrete.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
        where TContext : DbContext, new()

    {
        public void Add(TEntity entity)
        {
            using(TContext contextDb=new TContext())
            {
                var addedEntity = contextDb.Entry(entity);
                addedEntity.State = EntityState.Added;
                contextDb.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using(TContext contextdb=new TContext())
            {
                var deletedEntity = contextdb.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                contextdb.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using(TContext contextDb=new TContext())
            {
                return contextDb.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using(TContext contextDb=new TContext())
            {
                return filter == null ?
                    contextDb.Set<TEntity>().ToList() :
                    contextDb.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using(TContext contextDb=new TContext())
            {
                var updatedEntity = contextDb.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                contextDb.SaveChanges();
            }
        }
    }
}
