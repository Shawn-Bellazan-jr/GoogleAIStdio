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
    public class PartConfiguration : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> builder)
        {
            builder.ToTable("Parts");

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Text)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .HasMany(x => x.Contents)
                .WithMany(x => x.Parts)
                .UsingEntity(
                "ContentPart",
                a => a.HasOne(typeof(Part)).WithMany().HasForeignKey("PartsId").HasPrincipalKey(nameof(Part.Id)),
                b => b.HasOne(typeof(Content)).WithMany().HasForeignKey("ContentsId").HasPrincipalKey(nameof(Content.Id)),
                ab => ab.HasKey("ContentsId", "PartsId"));
        }
    }
}
