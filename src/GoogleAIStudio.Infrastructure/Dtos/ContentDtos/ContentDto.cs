using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Dtos.ContentDtos
{
    public record PartDto(
        [property: JsonPropertyName("text")] string Text);
    public record ContentDto(
        [property: JsonPropertyName("role")] string Role,
        [property: JsonPropertyName("parts")] ICollection<PartDto> Parts);
    public record PromptDto(
        [property: JsonPropertyName("contents")] ICollection<ContentDto> Contents);
}
