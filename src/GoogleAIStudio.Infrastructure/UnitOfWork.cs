using GoogleAIStudio.Core.Interfaces.IPrompts;
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

            var _freeformRepository = new FreeformPromptRepository(_context);
            var _structuredRepo = new StructuredPromptRepository(_context);
            var _chatRepo = new ChatPromptRepository(_context);

            var _googleAiStudio = "https://generativelanguage.googleapis.com/v1";
            var _restClient = new RestClient(_googleAiStudio);

            FreeformPrompts = new FreeformPromptService(_freeformRepository, _restClient);
        }
        public IFreeformPromptService FreeformPrompts {  get; }


        public async Task Save()
        {
           await _context.SaveChangesAsync();
        }
    }
}
