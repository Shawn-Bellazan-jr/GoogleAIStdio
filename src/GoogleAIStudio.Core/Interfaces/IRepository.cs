using GoogleAIStudio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Interfaces
{
    public interface IRepository<T> where T : BaseModel
    {
        Task<bool> ExistAsync(T type);
        Task<T?> AddAsync(T type);
        Task<T?> GetAsync(T type);
        Task<T?> GetAsync(string id);
        Task<IEnumerable<T>> GetAsync();

    }
}
