using GoogleAIStudio.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.DTOs.ContentDto
{
    public class ContentDto
    {
        public string Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Part> Parts { get; set; } = new List<Part>();
    }
}
