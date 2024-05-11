using GoogleAIStudio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Interfaces
{
    public interface IService<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T type);
        Task<T> UpdateAsync(T type);
        Task DeleteAsync(int id);
    }
}
