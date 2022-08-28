using eCommerceAPI.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly RepositoryDbContext _dbContext;

        public RepositoryBase(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _dbContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }
    }
}
