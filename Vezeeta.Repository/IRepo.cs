using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Models;

namespace Vezeeta.Repository
{
    public interface IRepo<T> where T : class
    {
        //Task<T> RegisterAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Expression<Func<T, bool>> expression);
        Task<bool> AddAsync(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
