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

        public DbSet<Models.Program> Programs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<LearningObject> LearningObjects { get; set; }
        public DbSet<SkippingAssignment> SkippingAssignments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentProgram> StudentProgram { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>()
               .HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<string>>()
                .HasKey(x => x.UserId);
            builder.Entity<IdentityUserToken<string>>()
                .HasKey(x => x.UserId);

            builder.Entity<StudentCourse>()
                .HasKey( slo => new { slo.CourseId, slo.StudentId});
            builder.Entity<StudentCourse>()
                .HasOne(slo => slo.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey (slo => slo.StudentId);
            builder.Entity<StudentCourse>()
                .HasOne(slo => slo.Course)
                .WithMany(lo => lo.StudentCourses)
                .HasForeignKey(slo => slo.CourseId);

            builder.Entity<StudentProgram>()
                .HasKey(sc => new { sc.StudentId, sc.ProgramId });
            builder.Entity<StudentProgram>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.CompleatedPrograms)
                .HasForeignKey(sc => sc.StudentId);
            builder.Entity<StudentProgram>()
                .HasOne(sc => sc.Program)
                .WithMany(c => c.StudentProgram)
                .HasForeignKey(sc => sc.ProgramId);
        }
    }
}
