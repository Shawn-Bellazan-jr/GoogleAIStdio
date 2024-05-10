﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Interfaces
{
    public interface IPromptService<Prompt>
    {
        Task<Prompt> CreatePrompt();
    }
}
