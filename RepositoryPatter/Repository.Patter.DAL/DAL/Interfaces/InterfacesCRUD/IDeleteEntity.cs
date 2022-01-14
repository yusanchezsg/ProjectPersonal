namespace Repository.Patter.DAL.Interfaces.InterfacesCRUD
{
    public interface IDeleteEntity<TEntity> where TEntity : class
    {
        bool Delete(TEntity entity);
    }
}
