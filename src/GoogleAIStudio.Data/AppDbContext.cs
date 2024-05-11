using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<FreeformPrompt> FreeformPrompts { get; set; }
        public DbSet<StructuredPrompt> StructuredPrompts { get; set; }
        public DbSet<ChatPrompt> ChatPrompts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=TooensureLLC\COMPANY;Initial Catalog=GoogleAIStudio;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FreeformPromptConfiguration());
        }
    }
}
