using Repository.Patter.DAL.Interfaces.InterfacesCRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Patter.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> : ICreateEntity<TEntity>, 
                                                   IDeleteEntity<TEntity>,
                                                   IGetEntity<TEntity>,
                                                   IUpdateEntity<TEntity> 
                                                   where TEntity : class 
    {
    }
}
