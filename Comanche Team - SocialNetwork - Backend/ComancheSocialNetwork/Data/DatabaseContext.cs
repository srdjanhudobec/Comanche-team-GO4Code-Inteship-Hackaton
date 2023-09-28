
using ComancheSocialNetwork.DTOs.Comment;
using ComancheSocialNetwork.DTOs.User;
using ComancheSocialNetwork.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace ComancheSocialNetwork.Data
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<User> users { get; set; }

        public DbSet<AttachmentModel> attachments { get; set; }

        public DbSet<Comment> comments { get; set; }

        public DbSet<Post> posts { get; set; }

        public DbSet<Rating> ratings { get; set; }

        public DbSet<View> views { get; set; }

        //public DbSet<Label> labels { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CommentPostGet>().HasNoKey();
        }
    }
}
