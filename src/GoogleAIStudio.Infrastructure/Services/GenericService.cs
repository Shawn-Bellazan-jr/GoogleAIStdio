using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services
{
    public abstract class GenericService<T> : IService<T> where T : BaseModel
    {
        private readonly IRepository<T> _repo;
        protected readonly IRestClient _client;

        protected GenericService(IRepository<T> repository, IRestClient client)
        {
            _repo = repository;
            _client = client;
        }
        public async Task<T?> AddAsync(T type)
        {
            return await _repo.AddAsync(type);
        }

        public async Task<bool> ExistAsync(T type)
        {
            return await _repo.ExistAsync(type);
        }

        public async Task<T?> GetAsync(T type)
        {
            return await _repo.GetAsync(type);
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _repo.GetAsync();
        }
    }
}
