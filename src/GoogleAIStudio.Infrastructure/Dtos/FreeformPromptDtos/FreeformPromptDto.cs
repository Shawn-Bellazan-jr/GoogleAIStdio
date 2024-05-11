using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Dtos.FreeformPromptDtos
{
    public class FreeformPromptDto
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? InitialText { get; set; }
    }
}
