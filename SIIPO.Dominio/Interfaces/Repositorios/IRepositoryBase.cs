using System.Collections.Generic;

namespace SIIPO.Dominio.Interfaces.Repositorios
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}