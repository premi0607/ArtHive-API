using ArtHive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtHive.Infrastructure.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<SavedPosts> SavedPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Likes Table
            modelBuilder.Entity<Likes>()
                .HasKey(l => new { l.UserId, l.PostId }); // Composite primary key

            modelBuilder.Entity<Likes>()
                .HasOne(l => l.Users)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete for Users as sql is not allowing multiple cascading delete

            modelBuilder.Entity<SavedPosts>()
                .HasOne(s => s.Users)
                .WithMany(u => u.SavedPosts)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);// Prevent cascading delete for Users

        }
    }
}
