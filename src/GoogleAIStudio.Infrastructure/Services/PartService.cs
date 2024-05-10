using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Services.IServices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services
{
    public class PartService : GenericService<Part>, IPartService
    {
        public PartService(IRepository<Part> repository, IRestClient client) : base(repository, client)
        {
        }
    }
}
