using GoogleAIStudio.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Data.Configurations
{
    public class StructuredPromptConfiguration: PromptConfiguration<StructuredPrompt>
    {
        public override void Configure(EntityTypeBuilder<StructuredPrompt> builder)
        {
            builder.ToTable("StructuredPrompts");

            builder
                .HasMany(p => p.Fields)
                .WithOne(x => x.StructuredPrompt)
                .HasForeignKey(x => x.StructuredPromptId);

            base.Configure(builder);
        }
    }
}
