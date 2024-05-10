using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Domain.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : BaseModel
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T?> AddAsync(T type)
        {
            var response = await _dbSet.AddAsync(type);
            
            return response.Entity;
        }

        public async Task<bool> ExistAsync(T type)
        {
           return await _dbSet.AnyAsync(x => x.Id == type.Id);
        }

        public async Task<T?> GetAsync(T type)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == type.Id);
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetAsync(string id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
