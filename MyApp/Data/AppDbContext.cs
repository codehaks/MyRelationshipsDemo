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



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
            .HasOne<UserProfile>(u => u.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<UserProfile>(p => p.ProfileOfUserId);
        }
    }
}