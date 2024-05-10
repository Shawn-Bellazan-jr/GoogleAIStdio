using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GoogleAIStudio.Core.Models
{
    public class Content: BaseModel
    {
        public string Description { get; set; } = string.Empty;
        [JsonPropertyName("parts")]
        public ICollection<Part> Parts { get; set; } = new List<Part>();

        
    }
}
