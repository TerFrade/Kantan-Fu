using Kantan_Fu_Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kantan_Fu_Api.Controllers
{
    public class KantanFuDbContext : DbContext
    {
        #region DbContextSetup
        public KantanFuDbContext(DbContextOptions<KantanFuDbContext> options) : base(options) { }
        #endregion

        #region DbSets
        public DbSet<Test> Tests { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<TestTopic> TestTopics { get; set; }
        #endregion

        #region ModelCreation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestTopic>().HasKey(tt => new { tt.TestId, tt.TopicId });
            modelBuilder.Entity<TestTopic>()
            .HasOne<Test>(tt => tt.Test)
            .WithMany(t => t.TestTopics)
            .HasForeignKey(tt => tt.TestId);

            modelBuilder.Entity<TestTopic>()
            .HasOne<Topic>(tt => tt.Topic)
            .WithMany(t => t.TestTopics)
            .HasForeignKey(tt => tt.TopicId);
        }
        #endregion
    }
}
