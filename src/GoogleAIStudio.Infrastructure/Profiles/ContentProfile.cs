using AutoMapper;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.DTOs.ContentDto;
using GoogleAIStudio.Infrastructure.Resources.ContentResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Profiles
{
    public class ContentProfile: Profile
    {
        public ContentProfile()
        {
            CreateMap<Content, ContentDto>(); //


            CreateMap<PostContentResource, Content>(); //  
            CreateMap<GetContentResource, Content>(); //  


        }
    }
}
