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
        Task<IEnumerable<T>> GetAsync();
        Task<T?> GetAsync(string id);
        Task<T?> AddAsync(T type);
        Task<bool> Update(T type);
        Task<bool> Delete(string id);
    }
}
