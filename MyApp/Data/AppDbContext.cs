using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(p => p.Blog)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

        }
    }
}