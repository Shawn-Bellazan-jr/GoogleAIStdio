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
    public abstract class PromptConfiguration<T> : IEntityTypeConfiguration<T> where T : Prompt
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .HasMaxLength(100);

            builder.Property(p => p.CreatedDate);
            builder.Property(p => p.ModifiedDate);
        }
    }
}
