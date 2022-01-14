using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Patter.DAL.Interfaces.InterfacesCRUD
{
    public interface IGetEntity<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func< TEntity, bool>> parametersQuery);

        List<TEntity> Get();
    }
}
