using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class Part: BaseModel
    {
        public string Text { get; set; } = string.Empty;
        public ICollection<Content> Contents { get; set; } = new List<Content>();
    }
}
