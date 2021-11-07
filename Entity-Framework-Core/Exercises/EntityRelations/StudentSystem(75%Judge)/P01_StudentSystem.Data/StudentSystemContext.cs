using P01_StudentSystem.Data.Models;

using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        //In order to test the db
        public StudentSystemContext()
        {

        }

        //For judge or outer connection
        public StudentSystemContext([NotNull]DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Homework> HomeworkSubmissions { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }


        //To configure connection to your server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.CONNECTION_STRING);
            }
        }

        //To configure database relations (DDL) 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>(s =>
            {
                s.HasKey(sc => new { sc.StudentId, sc.CourseId });

               //s
               //.HasOne(e => e.Student)
               //.WithMany(e => e.CourseEnrollments)
               //.HasForeignKey(e => e.StudentId)
               //.OnDelete(DeleteBehavior.Restrict);
               //
               //s
               //.HasOne(e => e.Course)
               //.WithMany(e => e.StudentsEnrolled)
               //.HasForeignKey(e => e.CourseId)
               //.OnDelete(DeleteBehavior.Restrict);
            });
        }

    }
}
