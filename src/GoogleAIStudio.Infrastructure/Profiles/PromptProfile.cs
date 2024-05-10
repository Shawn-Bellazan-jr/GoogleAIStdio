using AutoMapper;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.DTOs.PromptDtos;
using GoogleAIStudio.Infrastructure.DTOs.PromptDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Profiles
{
    public class PromptProfile: Profile
    {
        public PromptProfile()
        {
            CreateMap<Prompt, PromptDto>();
            CreateMap<PromptDto, Prompt>();

            // CREATE
            CreateMap<CreatePromptDto, Prompt>();
            // READ
            CreateMap<Prompt, ReadPromptDto>();

        }
    }
}
