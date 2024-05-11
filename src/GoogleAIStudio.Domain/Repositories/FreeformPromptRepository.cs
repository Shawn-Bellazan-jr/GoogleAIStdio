using GoogleAIStudio.Core.Interfaces.IPrompts;
using GoogleAIStudio.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Domain.Repositories
{
    public class FreeformPromptRepository : PromptRepository<FreeformPrompt>, IFreeformPromptRepository
    {
        public FreeformPromptRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<FreeformPrompt>> GetFreeformPromptsByInitialText(string initialText)
        {
            var response = await _dbSet.ToListAsync();
            return response.Where(x => x.InitialText == initialText);
        }
    }
}
