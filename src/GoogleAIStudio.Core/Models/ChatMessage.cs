using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class ChatMessage: BaseModel
    {
        public string Sender { get; set; }  // "User" or "AI"
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
