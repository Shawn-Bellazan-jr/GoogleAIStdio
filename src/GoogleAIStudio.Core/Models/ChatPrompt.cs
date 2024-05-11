using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class ChatPrompt: Prompt
    {
        public ICollection<ChatMessage> ChatHistory { get; set; } = new List<ChatMessage>(); // History of chat messages


    }
}
