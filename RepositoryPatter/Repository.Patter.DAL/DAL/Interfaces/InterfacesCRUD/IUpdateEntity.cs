namespace Repository.Patter.DAL.Interfaces.InterfacesCRUD
{
    public interface IUpdateEntity<TEntity> where TEntity: class
    {
        bool Update(TEntity entity);

    }
}
