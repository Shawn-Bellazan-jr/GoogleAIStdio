﻿// <auto-generated />
using System;
using GoogleAIStudio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoogleAIStudio.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240510123517_InitialG")]
    partial class InitialG
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoogleAIStudio.Core.Models.ChatMessage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChatPromptId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChatPromptId");

                    b.ToTable("ChatMessage");
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.FreeformPrompt", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("InitialText")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("FreeformPrompts", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("FreeformPrompt");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.PromptField", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StructuredPromptId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StructuredPromptId");

                    b.ToTable("PromptField");
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.ChatPrompt", b =>
                {
                    b.HasBaseType("GoogleAIStudio.Core.Models.FreeformPrompt");

                    b.HasDiscriminator().HasValue("ChatPrompt");
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.StructuredPrompt", b =>
                {
                    b.HasBaseType("GoogleAIStudio.Core.Models.FreeformPrompt");

                    b.HasDiscriminator().HasValue("StructuredPrompt");
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.ChatMessage", b =>
                {
                    b.HasOne("GoogleAIStudio.Core.Models.ChatPrompt", null)
                        .WithMany("ChatHistory")
                        .HasForeignKey("ChatPromptId");
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.PromptField", b =>
                {
                    b.HasOne("GoogleAIStudio.Core.Models.StructuredPrompt", null)
                        .WithMany("Fields")
                        .HasForeignKey("StructuredPromptId");
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.ChatPrompt", b =>
                {
                    b.Navigation("ChatHistory");
                });

            modelBuilder.Entity("GoogleAIStudio.Core.Models.StructuredPrompt", b =>
                {
                    b.Navigation("Fields");
                });
#pragma warning restore 612, 618
        }
    }
}
