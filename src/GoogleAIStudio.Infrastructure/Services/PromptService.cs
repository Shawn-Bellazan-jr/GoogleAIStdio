using Azure.Core;
using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Interfaces.IPrompts;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Services.IServices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services
{
    public abstract class PromptService<P> : IPromptService<P> where P : Prompt
    {
        private readonly IPromptRepository<P> _repository;
        protected readonly IRestClient _client;

        protected PromptService(IPromptRepository<P> repository, IRestClient client)
        {
            _repository = repository;
            _client = client;
        }


        public async Task<P?> CreatePrompt(P prompt)
        {
            var response = await _repository.AddAsync(prompt);
            return response;
        }

        public async Task<IEnumerable<P>> GetAllPrompts()
        {
            var response = await _repository.GetAsync();
            return response;
        }
    }
}
