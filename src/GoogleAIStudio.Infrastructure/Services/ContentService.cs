using Azure.Core;
using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Resources.ContentResources;
using GoogleAIStudio.Infrastructure.Services.IServices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services
{
    public class ContentService : GenericService<Content>, IContentService
    {
        public ContentService(IRepository<Content> repository, IRestClient client) : base(repository, client)
        {

        }

    }
}
