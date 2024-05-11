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
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T?> AddAsync(T type)
        {
            var response =  await _context.AddAsync(type);
            return response.Entity;
        }

        public async Task<bool> Delete(string id)
        {
            var response = await GetAsync(id);
            if(response == null) return false;
            _context.Remove(response);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _context.Set<T>().ToListAsync();   
        }

        public async Task<T?> GetAsync(string id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(T type)
        {
            var response = await GetAsync(type.Id);
            if (response == null) return false;
            response = type;
            _context.Add(response);
            _context.SaveChanges();
            return true;
        }
    }
}
