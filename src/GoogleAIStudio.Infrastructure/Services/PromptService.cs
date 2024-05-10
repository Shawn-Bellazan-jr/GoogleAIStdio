using Azure.Core;
using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Resources.ContentResources;
using GoogleAIStudio.Infrastructure.Services.IServices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services
{
    public class PromptService : GenericService<Prompt>, IPromptService
    {
        public PromptService(IRepository<Prompt> repository, IRestClient client) : base(repository, client)
        {
        }

        public Task<Prompt> GenerateContent(Prompt prompt)
        {
            throw new NotImplementedException();
        }
        /*
       public async Task<Prompt> GenerateContent(string resource, Prompt prompt)
       {
           var response = await _client.PostJsonAsync<Prompt>(resource, prompt);
       }*/
    }
}
