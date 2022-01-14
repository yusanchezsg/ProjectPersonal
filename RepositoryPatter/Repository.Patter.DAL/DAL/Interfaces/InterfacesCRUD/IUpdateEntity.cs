using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Patter.DAL.Interfaces.InterfacesCRUD
{
    public interface IUpdateEntity<TEntity> where TEntity: class
    {
        bool Update(TEntity entity);

    }
}
