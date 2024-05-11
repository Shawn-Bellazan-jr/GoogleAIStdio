
using AutoMapper;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Dtos.FreeformPromptDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Profiles
{
    public class FreeformPromptProfile: Profile
    {
        public FreeformPromptProfile()
        {
            CreateMap<AddFreeformPromptDto, FreeformPrompt>();
            CreateMap<FreeformPrompt, FreeformPromptDto>();
        }
    }
}
