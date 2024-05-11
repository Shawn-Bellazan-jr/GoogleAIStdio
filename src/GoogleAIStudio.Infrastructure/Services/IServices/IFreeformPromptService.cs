using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Dtos.ContentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services.IServices
{
    public interface IFreeformPromptService: IPromptService<FreeformPrompt>
    {
        Task<string> SendPrompt(PromptDto prompt);
    }
}
