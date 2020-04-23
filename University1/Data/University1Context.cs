using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University1.Models;

namespace University1.Data
{
    public class University1Context : DbContext
    {
        public University1Context() { }
   
        public University1Context(DbContextOptions<University1Context> options)
            : base(options)
        {
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
               .HasOne<Student>(p => p.Student)
               .WithMany(p => p.Courses)
               .HasForeignKey(p => p.StudentId);

            //.HasPrincipalKey(p => p.Id);

            builder.Entity<Enrollment>()
               .HasOne<Course>(p => p.Course)
               .WithMany(p => p.Students)
               .HasForeignKey(p => p.CourseId);

            //.HasPrincipalKey(p => p.Id);

            builder.Entity<Course>()
                   .HasOne<Teacher>(p => p.FirstTeacher)
                   .WithMany(p => p.FTCourses)
                   .HasForeignKey(p => p.FirstTeacherId);
            //.HasPrincipalKey(p => p.Id);

            builder.Entity<Course>()
                   .HasOne<Teacher>(p => p.SecondTeacher)
                   .WithMany(p => p.STCourses)
                   .HasForeignKey(p => p.SecondTeacherId);


            //.HasPrincipalKey(p => p.Id);
        }


    }
}


