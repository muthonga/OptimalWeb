using Core.Entities;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Optimal
{
    public class Repo<T> : IRepo<T> where T : BaseEntity
    {
        protected readonly OptimalDbContext _dbContext;
        public Repo(OptimalDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T GetByKeys(params object[] keyVals)
        {
            return _dbContext.Set<T>().Find(keyVals);
        }

        public async Task<T> GetByKeysAsync(params object[] keyVals)
        {
            return await _dbContext.Set<T>().FindAsync(keyVals);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsEnumerable();
        }

        public async Task<List<T>> WhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public T Insert(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public async Task<T> InsertAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        

    }
}
