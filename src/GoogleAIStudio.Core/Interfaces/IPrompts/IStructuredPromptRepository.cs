using GoogleAIStudio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Interfaces.IPrompts
{
    public interface IStructuredPromptRepository: IPromptRepository<StructuredPrompt>
    {
        List<StructuredPrompt> GetStructuredPromptsByField(string fieldName, string fieldValue);

    }
}
