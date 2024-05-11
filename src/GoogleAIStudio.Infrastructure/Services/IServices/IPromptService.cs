using GoogleAIStudio.Core;
using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services.IServices
{
    public interface IPromptService<P> where P : Prompt
    {
        Task<P?> CreatePrompt(P prompt);
        Task<IEnumerable<P>> GetAllPrompts();
    }
}
