using GoogleAIStudio.Infrastructure.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure
{
    public interface IUnitOfWork
    {
        IPartService Parts { get; }
        IContentService Contents { get; }
        IPromptService Prompts { get; }
        Task Save();
    }
}
