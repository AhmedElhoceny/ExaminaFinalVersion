using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options):base(options)
        {

        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CourseStudentRelationship> CourseStudentRelationship { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Exam> Grads { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Reading> Reading { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Sheet> Sheet { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Video> Video { get; set; }
    }
}
