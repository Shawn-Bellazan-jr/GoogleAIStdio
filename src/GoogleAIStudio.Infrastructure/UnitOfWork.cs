using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Data;
using GoogleAIStudio.Domain.Repositories;
using GoogleAIStudio.Infrastructure.Services;
using GoogleAIStudio.Infrastructure.Services.IServices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public UnitOfWork()
        {
            _context = new AppDbContext();

            var _clientContentUrl = "";

            var _clientContent = new RestClient(_clientContentUrl)
                .AddDefaultHeader("Content-Type", "application/json");

            var _repositoryContent = new ContentRepository(_context);
            Contents = new ContentService(_repositoryContent, _clientContent);


        }
        public IPartService Parts {  get; }
        public IContentService Contents {  get; }
        public IPromptService Prompts {  get; }


        public async Task Save()
        {
           await _context.SaveChangesAsync();
        }
    }
}
