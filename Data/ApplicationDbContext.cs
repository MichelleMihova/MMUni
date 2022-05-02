using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MMUni.Models;

namespace MMUni.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<LearningObject> LearningObjects { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<SkippingAssignment> SkippingAssignments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StudentLearningObject> StudentLearningObjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>()
               .HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<string>>()
                .HasKey(x => x.UserId);
            builder.Entity<IdentityUserToken<string>>()
                .HasKey(x => x.UserId);

            builder.Entity<StudentLearningObject>()
                .HasKey( slo => new { slo.LearningObjectId, slo.StudentId});
            builder.Entity<StudentLearningObject>()
                .HasOne(slo => slo.Student)
                .WithMany(s => s.StudentLearningObjects)
                .HasForeignKey (slo => slo.StudentId);
            builder.Entity<StudentLearningObject>()
                .HasOne(slo => slo.LearningObject)
                .WithMany(lo => lo.StudentLearningObjects)
                .HasForeignKey(slo => slo.LearningObjectId);

            builder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.CompleatedCourses)
                .HasForeignKey(sc => sc.StudentId);
            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
        }
    }
}
