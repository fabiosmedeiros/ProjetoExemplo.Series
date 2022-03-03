using ProjetoExemplo.Series.Domain.Entities;
using ProjetoExemplo.Series.Domain.Interfaces;

namespace ProjetoExemplo.Series.Infra.Data.Repository
{
    public class SerieRepository : IRepositoryBase<Serie>
    {
        private List<Serie> listaDeseries = new List<Serie>();

        // Create
        public void Add(Serie entity)
        {
            listaDeseries.Add(entity);
        }

        // Recovery
        public Serie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Serie> GetAll()
        {
            throw new NotImplementedException();
        }

        // Update
        public void Update(int id, Serie entity)
        {
            listaDeseries[id] = entity;            
        }

        // Delete
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int proximoId()
        {
            throw new NotImplementedException();
        }
    }
}