using GoogleAIStudio.Core.Interfaces;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Domain.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Domain.Repositories
{
    public class PromptRepository : GenericRepository<Prompt>, IPromptRepository
    {
        public PromptRepository(DbContext context) : base(context)
        {
        }
    }
}
