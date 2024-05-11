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
    public class StructuredPromptRepository : PromptRepository<StructuredPrompt>, IStructuredPromptRepository
    {
        public StructuredPromptRepository(DbContext context) : base(context)
        {
        }

        public List<StructuredPrompt> GetStructuredPromptsByField(string fieldName, string fieldValue)
        {
            throw new NotImplementedException();
        }
    }
}
