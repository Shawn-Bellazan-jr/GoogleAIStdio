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
    public class PartRepository : GenericRepository<Part>, IPartRepository
    {
        public PartRepository(DbContext context) : base(context)
        {
        }
    }
}
