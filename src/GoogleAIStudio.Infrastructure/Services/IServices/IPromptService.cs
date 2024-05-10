using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Resources.ContentResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services.IServices
{
    public interface IPromptService: IService<Prompt>
    {
        Task<Prompt> GenerateContent(Prompt prompt);

    }
}
