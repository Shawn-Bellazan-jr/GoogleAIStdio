using AutoMapper;
using GoogleAIStudio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Profiles
{
    public class GenericMap<SOURCE, DESTINATION>: Profile
    {
        public GenericMap()
        {
            CreateMap<ISource<SOURCE>, IDestination<DESTINATION>>();
        }
    }
}
