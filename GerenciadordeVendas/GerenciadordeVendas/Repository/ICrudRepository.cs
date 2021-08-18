using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadordeVendas.Repository
{
    public interface ICrudRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> GetById(String id);
        Task Inserir(TEntity entity);
        Task Inserir(List<TEntity> entities);
        Task Update(TEntity Entity);
        Task Delete(TEntity entity);

    }
}
