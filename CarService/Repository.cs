using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ModelCarServiceContainer _dbContext;

        public Repository(ModelCarServiceContainer dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> List()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        /*
        public virtual IEnumerable<T> List(System.Data.Entity.Infrastructure.DbSqlQuery<Auto> dbSqlQuery)
        {
            return _dbContext.Set<T>().AsEnumerable();
        }
        */
        public virtual IEnumerable<T> List(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>()
                   .Where(predicate)
                   .AsEnumerable();
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            //_dbContext.Set<T>().Attach(entity);
            bool isDetached = _dbContext.Entry(entity).State == EntityState.Detached;
            if (isDetached)
                _dbContext.Set<T>().Attach(entity);
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
