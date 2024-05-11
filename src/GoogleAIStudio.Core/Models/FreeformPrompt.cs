using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class FreeformPrompt : Prompt
    {
        public string InitialText { get; set; } = string.Empty;  // Starting point for freeform generation
    }
}
