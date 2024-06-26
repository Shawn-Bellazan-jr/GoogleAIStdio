﻿using GoogleAIStudio.Core.Interfaces.IPrompts;
using GoogleAIStudio.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Domain.Repositories
{
    public abstract class PromptRepository<T> : GenericRepository<T>, IPromptRepository<T> where T : Prompt
    {
        protected PromptRepository(DbContext context) : base(context)
        {
        }
    }
}
