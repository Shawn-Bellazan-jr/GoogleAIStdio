﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class StructuredPrompt: Prompt
    {
        public ICollection<PromptField> Fields { get; set; } = new List<PromptField>();


    }
}
