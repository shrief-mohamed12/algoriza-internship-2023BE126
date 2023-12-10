using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Models;

namespace Vezeeta.Repository
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public Repo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddAsync(T entity)
        {
            if (entity is not null)
            {
                await _dbContext.Set<T>().AddAsync(entity);
                
            }
            return true;
        }
        public bool Delete(T entity)
        {
            if (entity is not null)
            {
                 _dbContext.Set<T>().Remove(entity);
               
            }
            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(expression);
        }

        public bool Update(T entity)
        {
            if (entity is not null)
            {
                _dbContext.Set<T>().Update(entity);
            }
            return true;
        }
        
    }
}
