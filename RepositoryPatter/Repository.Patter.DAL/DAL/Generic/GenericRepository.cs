using Repository.Patter.DAL.Context;
using Repository.Patter.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Patter.DAL.Generic
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _applicationContext;

        public GenericRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }

        public bool Create(TEntity entity)
        {
            _applicationContext.Set<TEntity>().Add(entity);
            return true;
        }

        public bool Delete(TEntity entity)
        {
            TEntity exists = _applicationContext.Set<TEntity>().Find(entity);
            if (exists != null)
                _applicationContext.Set<TEntity>().Remove(entity);
                
            return true;
        }

        public IEnumerable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> parametersQuery)
        {
            return _applicationContext.Set<TEntity>().Where(parametersQuery);
        }

        public List<TEntity> Get()
        {
            return _applicationContext.Set<TEntity>().ToList();
        }

        public bool Update(TEntity entity)
        {
            _applicationContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _applicationContext.Set<TEntity>().Attach(entity);
            return true;
        }
    }
}
