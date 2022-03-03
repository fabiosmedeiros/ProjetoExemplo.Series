namespace ProjetoExemplo.Series.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
         // Crud : Create
        void Add(TEntity entity);

        // cRud : Recovery
        TEntity GetById(int id); 
        List<TEntity> GetAll();

        // crUd : Update
        void Update(int id, TEntity entity);

        // cruD : Delete
        void Delete(int id);

        int ProximoId();
    }
}