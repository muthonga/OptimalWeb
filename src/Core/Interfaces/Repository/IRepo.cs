using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IRepo<T> where T : BaseEntity
    {
        T GetByKeys(params object[] keyVals);
        Task<T> GetByKeysAsync(params object[] keyVals);
        IEnumerable<T> GetAll();
        Task<List<T>> GetAllAsync();
        IEnumerable<T> Where(Expression<Func<T, bool>> predicate);
        Task<List<T>> WhereAsync(Expression<Func<T, bool>> predicate);
        T Insert(T entity);
        Task<T> InsertAsync(T entity);
        void Update(T entity);
        Task UpdateAsync(T entity);
        void Delete(T entity);
        Task DeleteAsync(T entity);
    }
}
