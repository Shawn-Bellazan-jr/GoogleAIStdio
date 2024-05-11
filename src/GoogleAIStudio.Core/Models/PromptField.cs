using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class PromptField: BaseModel
    {
        public string StructuredPromptId { get; set; }
        public StructuredPrompt StructuredPrompt { get; set; }
        public string Value { get; set; }
    }
}
