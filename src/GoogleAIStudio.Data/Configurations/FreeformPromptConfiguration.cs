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
    public class FreeformPromptConfiguration : PromptConfiguration<FreeformPrompt>
    {
        public override void Configure(EntityTypeBuilder<FreeformPrompt> builder)
        {
            builder.ToTable("FreeformPrompts");

            builder.Property(p => p.InitialText)
                .IsRequired()
                .HasMaxLength(100);

            base.Configure(builder);
        }
    }
}
