using GerenciadordeVendas.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadordeVendas.Repository
{
    public class CrudRepository<TEntity> : ICrudRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _contexto;

        public CrudRepository(DataContext contexto)
        {
            _contexto = contexto;
        }

        public async Task Delete(TEntity entity)
        {
            try
            {
                _contexto.Set<TEntity>().Remove(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _contexto.Set<TEntity>();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {
                var entity = await _contexto.Set<TEntity>().FindAsync(id);
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> GetById(string id)
        {
            try
            {
                var entity = await _contexto.Set<TEntity>().FindAsync(id);
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            };
        }

        public async Task Inserir(TEntity entity)
        {
            try
            {
                await _contexto.AddAsync(entity);
                await _contexto.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Inserir(List<TEntity> entities)
        {
            try
            {
                await _contexto.AddRangeAsync(entities);
                await _contexto.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Update(TEntity Entity)
        {
            try
            {
                var registro = _contexto.Set<TEntity>().Update(Entity);
                registro.State = EntityState.Modified;
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}