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
    public class ChatPromptRepository : PromptRepository<ChatPrompt>, IChatPromptRepository
    {
        public ChatPromptRepository(DbContext context) : base(context)
        {
        }

        public List<ChatPrompt> GetChatPromptsByParticipant(string participant)
        {
            throw new NotImplementedException();
        }
    }
}
