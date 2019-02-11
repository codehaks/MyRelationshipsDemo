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

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CourseStudent>()
                .HasKey(c => new { c.StudentId, c.CourseId });

            builder.Entity<CourseStudent>()
                .HasOne(c => c.Course)
                .WithMany(c => c.CourseStudents)
                .HasForeignKey(c => c.CourseId);

            builder.Entity<CourseStudent>()
               .HasOne(s => s.Student)
               .WithMany(s => s.CourseStudents)
               .HasForeignKey(s => s.StudentId);

        }
    }
}