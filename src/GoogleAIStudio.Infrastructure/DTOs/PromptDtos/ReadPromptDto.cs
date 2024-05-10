using GoogleAIStudio.Infrastructure.DTOs.PromptDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.DTOs.PromptDtos
{
    public class ReadPromptDto: PromptDto
    {
        [Required]
        public string Id { get; set; } = string.Empty;

    }
}
