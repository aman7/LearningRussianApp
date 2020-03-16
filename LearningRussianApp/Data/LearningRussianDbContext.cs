using LearningRussianApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRussianApp.Data
{
    public class LearningRussianDbContext:DbContext
    {
        public LearningRussianDbContext(DbContextOptions<LearningRussianDbContext> options) : base(options)
        {

        }
        public DbSet<Noun> nouns { get; set; }
        public DbSet<Verb> verbs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Noun>()
                .HasIndex(u => u.russWord)
                .IsUnique();
            builder.Entity<Verb>()
                .HasIndex(u => u.russWord)
                .IsUnique();
        }
    }
}
