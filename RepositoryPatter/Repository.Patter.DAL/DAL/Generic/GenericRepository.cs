using Repository.Patter.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Patter.DAL.Generic
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public TEntity Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> parametersQuery)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
