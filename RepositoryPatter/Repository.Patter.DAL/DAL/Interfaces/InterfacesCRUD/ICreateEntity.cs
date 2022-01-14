namespace Repository.Patter.DAL.Interfaces.InterfacesCRUD
{
    public interface ICreateEntity<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
    }
}
