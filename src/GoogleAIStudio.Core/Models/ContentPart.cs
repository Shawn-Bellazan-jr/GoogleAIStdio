using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class ContentPart
    {
        public string ContentsId { get; set; } = string.Empty;
        public string PartsId { get; set; } = string.Empty;
        public Part? Part { get; set; } = null;
        public Content? Content { get; set; } = null;
    }
}

