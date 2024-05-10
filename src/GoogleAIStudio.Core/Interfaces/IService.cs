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
        Task<bool> ExistAsync(T type);
        Task<T?> AddAsync(T type);
        Task<T?> GetAsync(T type);
        Task<IEnumerable<T>> GetAsync();
    }
}
