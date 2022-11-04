using MathCornerForum_aspnetcore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MathCornerForum_aspnetcore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<PostReply>()
                .HasOne(e => e.Post)
                .WithMany(e => e.PostReplies)
                .HasForeignKey(p => p.PostId)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<Post>()
                .HasOne(e => e.Author)
                .WithMany(e => e.Posts)
                .HasForeignKey(p => p.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder
                .Entity<PostReply>()
                .HasOne(e => e.Author)
                .WithMany(e => e.PostReplies)
                .HasForeignKey(p => p.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientCascade);


            modelBuilder.Entity<PostReply>(b =>
            {
                b.HasKey(pr => pr.Id);
                b.Property(pr => pr.Content).HasMaxLength(3000);
            });

            modelBuilder.Entity<Post>(b =>
            {
                b.HasKey(p => p.Id);

                b.Property(p => p.Subject).HasMaxLength(50);
                b.Property(p => p.Title).HasMaxLength(50);
                b.Property(p => p.Content).HasMaxLength(3000);
            });

            modelBuilder.Entity<User>(b =>
            {
                b.HasKey(u => u.Id);

                b.Property(u => u.UserName).HasMaxLength(30).IsRequired();
                b.Property(u => u.Password).IsRequired();
            });

        }
    }
}
