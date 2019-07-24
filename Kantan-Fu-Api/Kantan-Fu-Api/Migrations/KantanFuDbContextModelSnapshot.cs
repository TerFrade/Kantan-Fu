﻿// <auto-generated />
using System;
using Kantan_Fu_Api.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kantan_Fu_Api.Migrations
{
    [DbContext(typeof(KantanFuDbContext))]
    partial class KantanFuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kantan_Fu_Api.Models.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Kantan_Fu_Api.Models.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Kantan_Fu_Api.Models.TestTopic", b =>
                {
                    b.Property<Guid>("TestId");

                    b.Property<int>("TopicId");

                    b.HasKey("TestId", "TopicId");

                    b.HasIndex("TopicId");

                    b.ToTable("TestTopics");
                });

            modelBuilder.Entity("Kantan_Fu_Api.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Kantan_Fu_Api.Models.Lesson", b =>
                {
                    b.HasOne("Kantan_Fu_Api.Models.Topic", "Topic")
                        .WithMany("Lessons")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kantan_Fu_Api.Models.TestTopic", b =>
                {
                    b.HasOne("Kantan_Fu_Api.Models.Test", "Test")
                        .WithMany("TestTopics")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kantan_Fu_Api.Models.Topic", "Topic")
                        .WithMany("TestTopics")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
